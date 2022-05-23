using System;
using System.Drawing;
using System.Windows.Forms;

namespace winforms
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            lbl_hello.Text = "hello!";
        }


        private void btn_puro_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("Puro_gun.png");
        }

        
    }
}
