using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test01
{
    public partial class MainForm : Mes.ControlsEx.ExtendForm.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, Mes.Core.ApplicationObject.SystemNavigatorClickedEventArgs e)
        {
            QueryForm form = new QueryForm();
            form.ShowDialog();
            if (form.QueryFlag) {
                this.navigatorEx1.QuerySql = form.QuerySql;
            }
        }
    }
}
