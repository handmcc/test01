using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] path = Directory.GetFiles(@"C:\Users\HAND-MC\Desktop\Picture");
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"C:\Users\HAND-MC\Desktop\Picture\1.jpg");
           
        }
        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i == path.Length) {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[i]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0) {
                i = path.Length - 1;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
