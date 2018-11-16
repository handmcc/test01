using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string shType = "";//收支类型
            if (radio1.Checked) {
                shType = radio1.Text;
            }
            else if (radio2.Checked) {
                shType = radio2.Text;
            }
            DateTime date = dateTimePicker1.Value;//时间
            string dateTime = date.ToString("yyyy-mm-dd");
            string szSize = this.comboBox1.SelectedItem.ToString();//收支类别
            string szProject = this.comboBox2.SelectedItem.ToString();//收支项目
            string explain = textBox1.Text;//说明
            MessageBox.Show(shType);
            ArrayList list = new ArrayList();
            
            
            //for (int i = 0; i < list.Count; i++) {
                
            //}


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = label9.Text.Substring(1) + label9.Text.Substring(0, 1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString();
        }

      
    }
}
