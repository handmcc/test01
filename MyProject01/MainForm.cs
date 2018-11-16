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
    public partial class MainForm : Mes.ControlsEx.ExtendForm.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            navigatorEx1.DataGridView = dataGridViewEx1;//将navigatorEx1和DataGridView绑定
            navigatorEx1.StatusStrip = statusStripBarEx1;
            
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navigatorEx1_OnQuery(object sender, Mes.Core.ApplicationObject.SystemNavigatorClickedEventArgs e)
        {
            QueryForm queryForm = new QueryForm();
            queryForm.ShowDialog();
            if (queryForm.QueryFlag) {
                this.navigatorEx1.QuerySql = queryForm.QuerySql;
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void navigatorEx1_OnSave(object sender, Mes.Core.ApplicationObject.SystemNavigatorClickedEventArgs e)
        {
            if (this.dataGridViewEx1.AddedRows.Count > 0) {
                this.navigatorEx1.InsertSqlList = this.SaveOrUpdate(this.dataGridViewEx1.AddedRows,true);
            }
            if (this.dataGridViewEx1.ChangedRows.Count > 0) {
                this.navigatorEx1.UpdateSqlList = this.SaveOrUpdate(this.dataGridViewEx1.ChangedRows, false);
            }
        }

        private List<string> SaveOrUpdate(List<string> list, bool flag) {
            List<string> InsertOrUpdatelist = new List<string>();
            string sql = string.Empty, enddate = "9999-12-31";
            for (int i = 0; i < list.Count; i++) {
                int num = Convert.ToInt32(list[i]);
                List<string> l = new List<string>();
                l.Add(Mes.Core.Utility.StrUtil.ValueToString(dataGridViewEx1.Rows[num].Cells[this.Column1.Name].Value));//获取行号对应的值
                l.Add(Mes.Core.Utility.StrUtil.ValueToString(dataGridViewEx1.Rows[num].Cells["description"].Value));//
                l.Add(Mes.Core.Utility.StrUtil.ValueToString(dataGridViewEx1.Rows[num].Cells["plant_id"].Value));
                l.Add(Mes.Core.Utility.StrUtil.ValueToString(dataGridViewEx1.Rows[num].Cells[this.colWareHouse.Name].Value));
                l.Add(Mes.Core.Utility.StrUtil.ValueToString(dataGridViewEx1.Rows[num].Cells["start_date"].Value.ToString().Substring(0,10)));
                enddate = string.IsNullOrEmpty(Mes.Core.Utility.StrUtil.ValueToString(dataGridViewEx1.Rows[num].Cells["end_date"].Value)) ? "9999-12-31" : dataGridViewEx1.Rows[num].Cells["end_date"].Value.ToString();
                l.Add(enddate.Substring(0,10));
                //修改数据库包中的存储过程
                if (flag == true) {
                    sql = "{?=call xerp_physical_locator_pck.insert_row_for_ui(" + template + ")}";
                } else{
                    sql = "{? = call xerp_physical_locator_pck.update_row_for_ui(" + template + ")}";
                }
                InsertOrUpdatelist.Add(sql);
                 
               
            }
            return InsertOrUpdatelist;
        }

        private void dataGridViewEx1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
