using System;
using System.Windows.Forms;
using System.Drawing;
namespace Basciinfinity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Color color;
        public string name = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            //Check for parameters
            Background.BackColor = color;
        }
       
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "") textBox1.Text = "blank";
                name = ":" + textBox1.Text + ":";
                this.DialogResult = DialogResult.OK;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
