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
    public partial class QueryForm : Mes.ControlsEx.ExtendForm.QueryForm
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
           OnQuery += QueryForm_OnQuery;
            OnCancelQuery +=QueryForm_OnCancelQuery;

            Mes.ControlsEx.LovFormExParameter test1 = new Mes.ControlsEx.LovFormExParameter();
            //Mes.ControlsEx.LovFormExParameter test2 = new Mes.ControlsEx.LovFormExParameter();
            test1.QuerySql = @"select plant_id,plant_code,DESCRIPTIONS from HCM_PLANT where 1=1";
            test1.LovFormExTitle = "工厂";
            test1.ColumnsName.Add("ID");
            test1.ColumnsName.Add("工厂编号");
            test1.ColumnsName.Add("工厂描述");
            test1.ColumnVisableList.Add(true);
            test1.ColumnVisableList.Add(true);
            test1.ColumnVisableList.Add(true);
            test1.TargetTextBoxEx = tbPlantId;
            lovButtonEx1.LovParameter = test1;

        }

        private void QueryForm_OnCancelQuery(object sender, EventArgs e)
        {
            QueryFlag = false;
            Mes.ControlsEx.ControlService.ClearSubControl(this);

        }

        private void QueryForm_OnQuery(object sender, EventArgs e)
        {
            QueryFlag = true;
            QuerySql = @"select hhib.barcode,
                           hhib.sgl_code,
                           hhib.creation_date,
                           hsbr.srm_code srm_code,
                           hhib.packet_quantity,
                           hhib.packing,
                           hi.item_code,
                           hi.descriptions,
                            hp.PLANT_CODE,
                            hp.DESCRIPTIONS as plant_DESCRIPTIONS
                      from hme_hz_inside_barcode hhib,
                           hme_hz_sgl_item       hhsi,
                           hme_srm_barcode_relation hsbr,
                           hcm_item              hi,
                            hcm_plant hp
                     where hhsi.item_id = hi.item_id and hhsi.PLANT_ID = hp.PLANT_ID and hhib.created_by = hsbr.created_by(+)
                            and rownum <= 3000";
            if (!string.IsNullOrEmpty(tbPlantId.Text))
            {
                QuerySql += @" AND HP.PLANT_ID " + Mes.Core.Utility.StrUtil.ProcInput(this.tbPlantId.Text, false);
            }
            if (!string.IsNullOrEmpty(tbItemNo.Text))
            {
                QuerySql += @" AND HI.ITEM_CODE " + Mes.Core.Utility.StrUtil.ProcInput(this.tbItemNo.Text, false);
            }
            if (!string.IsNullOrEmpty(tbCreationStart.Text) && !string.IsNullOrEmpty(tbCreationEnd.Text)) {
                QuerySql += @" AND HHIB.CREATION_DATE BETWEEN TO_DATE('" + this.tbCreationStart.Text + "','YYYY-MM-DD HH24:mi:ss') AND TO_DATE('" + this.tbCreationEnd.Text + "','YYYY-MM-DD HH24:mi:ss')"; 
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lovButtonEx2_Click(object sender, EventArgs e)
        {
            Mes.ControlsEx.LovFormExParameter test2 = new Mes.ControlsEx.LovFormExParameter();
            test2.QuerySql = @"select item_id,item_code,descriptions from hcm_item where 1=1 and plant_id " + Mes.Core.Utility.StrUtil.ProcInput(this.tbPlantId.Text, false);
            test2.LovFormExTitle = "物料";
            test2.ColumnsName.Add("ID");
            test2.ColumnsName.Add("物料编码");
            test2.ColumnsName.Add("物料描述");
            test2.ColumnVisableList.Add(true);
            test2.ColumnVisableList.Add(true);
            test2.ColumnVisableList.Add(true);
            test2.TargetTextBoxEx = tbItemNo;
            lovButtonEx2.LovParameter = test2;
        }
        
    }
}
