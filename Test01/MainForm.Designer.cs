namespace Test01
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Mes.ControlsEx.Class.ORM orm1 = new Mes.ControlsEx.Class.ORM();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext1 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.panelEx1 = new Mes.ControlsEx.PanelEx(this.components);
            this.dataGridViewEx1 = new Mes.ControlsEx.DataGridViewEx(this.components);
            this.statusStripBarEx1 = new Mes.ControlsEx.StatusStripBarEx();
            this.navigatorEx1 = new Mes.ControlsEx.NavigatorEx();
            this.ColBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSglCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSrmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPacketQuantiy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPacket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPalntCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPlantDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.dataGridViewEx1);
            this.panelEx1.Controls.Add(this.statusStripBarEx1);
            this.panelEx1.Controls.Add(this.navigatorEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(767, 433);
            this.panelEx1.TabIndex = 0;
            
            // 
            // dataGridViewEx1
            // 
            this.dataGridViewEx1.AddedRows = ((System.Collections.Generic.List<string>)(resources.GetObject("dataGridViewEx1.AddedRows")));
            this.dataGridViewEx1.AllowUserToAddRows = false;
            this.dataGridViewEx1.AllowUserToOrderColumns = true;
            this.dataGridViewEx1.AutoQuerySql = null;
            this.dataGridViewEx1.ChangedRows = ((System.Collections.Generic.List<string>)(resources.GetObject("dataGridViewEx1.ChangedRows")));
            this.dataGridViewEx1.CheckBoxCellIndex = -1;
            this.dataGridViewEx1.CheckBoxCheckedRow = null;
            this.dataGridViewEx1.ColumnHeadersHeight = 30;
            this.dataGridViewEx1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBarcode,
            this.ColSglCode,
            this.ColCreationDate,
            this.ColSrmCode,
            this.ColPacketQuantiy,
            this.ColPacket,
            this.ColItemCode,
            this.ColDescription,
            this.ColPalntCode,
            this.ColPlantDescription});
            orm1.ColumnCommPropertyList = "";
            orm1.DelSqlTemplate = "";
            orm1.InsertSqlTemplate = "";
            orm1.PrimaryTable = "";
            orm1.SelectSqlTemplate = "";
            orm1.UpdateSqlTemplate = "";
            this.dataGridViewEx1.DBORM = orm1;
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewEx1.ErrorRowList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.ErrorRowList")));
            this.dataGridViewEx1.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Mixed;
            this.dataGridViewEx1.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dataGridViewEx1.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dataGridViewEx1.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Custom1;
            this.dataGridViewEx1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewEx1.IsCheckBoxBecomeRadio = false;
            this.dataGridViewEx1.IsMergeColumn = false;
            this.dataGridViewEx1.IsUseORM = false;
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.NeedReceIveValue = false;
            this.dataGridViewEx1.OperationMode = "None";
            this.dataGridViewEx1.PkCellIndex = 0;
            this.dataGridViewEx1.ReceiveValueColumnIndex = -1;
            this.dataGridViewEx1.RelationDataGridView = null;
            this.dataGridViewEx1.RelationDataGridViewColumnIndexList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.RelationDataGridViewColumnIndexList")));
            this.dataGridViewEx1.RelationDataGridViewQuerySql = "";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(767, 381);
            this.dataGridViewEx1.TabIndex = 3;
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 411);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Size = new System.Drawing.Size(767, 22);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.CancelAddRowEvent = false;
            this.navigatorEx1.Context = windowsFormsSynchronizationContext1;
            this.navigatorEx1.DataGridView = this.dataGridViewEx1;
            this.navigatorEx1.DelsqlList = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.DelsqlList")));
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.InsertSqlList = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.InsertSqlList")));
            this.navigatorEx1.IsUserControlStatusMsg = false;
            this.navigatorEx1.LastAddRowIndex = -1;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Name = "navigatorEx1";
            this.navigatorEx1.QueryRowsCountSql = "";
            this.navigatorEx1.QuerySql = "";
            this.navigatorEx1.ShowAddBtn = false;
            this.navigatorEx1.ShowChooseAllBtn = false;
            this.navigatorEx1.ShowClearBtn = false;
            this.navigatorEx1.ShowDelBtn = false;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = false;
            this.navigatorEx1.Size = new System.Drawing.Size(767, 30);
            this.navigatorEx1.SqlExecuteResult = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.SqlExecuteResult")));
            this.navigatorEx1.StatusStrip = this.statusStripBarEx1;
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.TbAbbreviated = "";
            this.navigatorEx1.UpdateSqlList = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.UpdateSqlList")));
            this.navigatorEx1.OnQuery += new Mes.Core.ApplicationObject.SystemNavigatorClickedEventHandler(this.navigatorEx1_OnQuery);
            // 
            // ColBarcode
            // 
            this.ColBarcode.HeaderText = "小条码编码";
            this.ColBarcode.Name = "ColBarcode";
            // 
            // ColSglCode
            // 
            this.ColSglCode.HeaderText = "大条码编码";
            this.ColSglCode.Name = "ColSglCode";
            // 
            // ColCreationDate
            // 
            this.ColCreationDate.HeaderText = "生产日期";
            this.ColCreationDate.Name = "ColCreationDate";
            // 
            // ColSrmCode
            // 
            this.ColSrmCode.HeaderText = "一次性小条码";
            this.ColSrmCode.Name = "ColSrmCode";
            // 
            // ColPacketQuantiy
            // 
            this.ColPacketQuantiy.HeaderText = "单包数量";
            this.ColPacketQuantiy.Name = "ColPacketQuantiy";
            // 
            // ColPacket
            // 
            this.ColPacket.HeaderText = "包装";
            this.ColPacket.Name = "ColPacket";
            // 
            // ColItemCode
            // 
            this.ColItemCode.HeaderText = "物料编码";
            this.ColItemCode.Name = "ColItemCode";
            // 
            // ColDescription
            // 
            this.ColDescription.HeaderText = "物料描述";
            this.ColDescription.Name = "ColDescription";
            // 
            // ColPalntCode
            // 
            this.ColPalntCode.HeaderText = "仓库编码";
            this.ColPalntCode.Name = "ColPalntCode";
            // 
            // ColPlantDescription
            // 
            this.ColPlantDescription.HeaderText = "仓库描述";
            this.ColPlantDescription.Name = "ColPlantDescription";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 433);
            this.Controls.Add(this.panelEx1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            this.ResumeLayout(false);
            this.TabText = "小条码测试";
            this.Text = "小条码测试";

        }

        #endregion

        private Mes.ControlsEx.PanelEx panelEx1;
        private Mes.ControlsEx.DataGridViewEx dataGridViewEx1;
        private Mes.ControlsEx.StatusStripBarEx statusStripBarEx1;
        private Mes.ControlsEx.NavigatorEx navigatorEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSglCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSrmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPacketQuantiy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPacket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPalntCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPlantDescription;
    }
}