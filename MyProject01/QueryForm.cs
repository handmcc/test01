using Mes.Core.ApplicationObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyProject01
{
    public partial class QueryForm : Mes.ControlsEx.ExtendForm.QueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            panelEx1.Dock = DockStyle.Fill;
            cmbTest.InitType = ComboBoxInitType.FASTWITHNULL;

            cmbTest.InitFastCodeOrSql = "YES_NO";
            cmbTest.InitType = ComboBoxInitType.SQLWITHNULL;
            cmbTest.InitFastCodeOrSql = "select id,name feom table";

            Mes.ControlsEx.LovFormExParameter test = new Mes.ControlsEx.LovFormExParameter();
            test.QuerySql = @"select id,code,className,className from classtable a where a.className"
                            + Mes.Core.Utility.StrUtil.SQL_PLACEHOLDER;

            test.LovFormExTitle = "班级";
            test.ColumnsName.Add("ID");
            test.ColumnsName.Add("班级编号");
            test.ColumnsName.Add("班级名称");
            test.ColumnVisableList.Add(true);
            test.ColumnVisableList.Add(true);
            test.ColumnVisableList.Add(true);
            test.TargetTextBoxEx = textBoxEx1;
            lovButtonEx1.LovParameter = test;
        }

        private void textBoxEx1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
