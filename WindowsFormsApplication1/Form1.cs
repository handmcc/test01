using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = userName.Text;
            string password = password1.Text;
            MessageBox.Show("用户名为：" + name + ",用户密码为：" + password);
            if (name.Equals("admin") && password.Equals("admin"))
            {
                MessageBox.Show("登陆成功！");
            }
            else {
                MessageBox.Show("登陆失败，请输入正确的用户名和密码");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userName.Clear();
            password1.Clear();

        }
    }
}
