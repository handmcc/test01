using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public partial class MainForm : Mes.ControlsEx.ExtendForm.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void navigatorEx1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void selectAll(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panelEx1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            navigatorEx1.AddButton("xxx", selectAll);
            navigatorEx1.ChangeButtonStatus("xxx", true);
            navigatorEx1.DisableAlleButtons();

            statusStripBarEx1.ShowMessage("xxxxxx");//手动设置手动栏消息
            statusStripBarEx1.GetMessage();//状态栏获取信息
        }
    }
}
