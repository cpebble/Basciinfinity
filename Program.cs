using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Basciinfinity
{
    static class Program
    {

        static string filePath;
        static Dictionary<string,string> colors = new Dictionary<string,string>();

        [STAThread]
        static void Main(string[] args)
        {
            //Check for parameters
            filePath = args[0];
            
            Bitmap img = new Bitmap(filePath);

            string output = "";

            for (int i = 0; i < img.Height; i++)
            {
                for (int j = 0; j < img.Width; j++)
                {
                    Color pixel = img.GetPixel(j, i);   //Logic for parsing which replacer
                    try
                    {
                        output += colors[pixel.Name];
                    }
                    catch (KeyNotFoundException)
                    {
                        Form1 form = new Form1();
                        form.color = pixel;
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            colors.Add(pixel.Name, form.name);
                            output += colors[pixel.Name];
                            form.Dispose();
                        }
                        else return;

                    }

                }
                output += Environment.NewLine;
            }
            Console.Write(output);
            Clipboard.SetText(output);
            Console.ReadLine();
        }
    }
}
