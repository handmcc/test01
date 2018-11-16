namespace ClassLibrary1
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
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Mes.ControlsEx.Class.ORM orm2 = new Mes.ControlsEx.Class.ORM();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigatorEx1 = new Mes.ControlsEx.NavigatorEx();
            this.statusStripBarEx1 = new Mes.ControlsEx.StatusStripBarEx();
            this.panelEx1 = new Mes.ControlsEx.PanelEx(this.components);
            this.dataGridViewEx1 = new Mes.ControlsEx.DataGridViewEx(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeViewGrid1 = new Mes.ControlsEx.TreeViewGrid();
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigatorEx1
            // 
            this.navigatorEx1.CancelAddRowEvent = false;
            this.navigatorEx1.Context = windowsFormsSynchronizationContext2;
            this.navigatorEx1.DelsqlList = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.DelsqlList")));
            this.navigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigatorEx1.InsertSqlList = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.InsertSqlList")));
            this.navigatorEx1.IsUserControlStatusMsg = false;
            this.navigatorEx1.LastAddRowIndex = -1;
            this.navigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.navigatorEx1.Name = "navigatorEx1";
            this.navigatorEx1.QueryRowsCountSql = "";
            this.navigatorEx1.QuerySql = "";
            this.navigatorEx1.ShowAddBtn = true;
            this.navigatorEx1.ShowChooseAllBtn = true;
            this.navigatorEx1.ShowClearBtn = true;
            this.navigatorEx1.ShowDelBtn = true;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = true;
            this.navigatorEx1.Size = new System.Drawing.Size(680, 30);
            this.navigatorEx1.SqlExecuteResult = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.SqlExecuteResult")));
            this.navigatorEx1.TabIndex = 0;
            this.navigatorEx1.TbAbbreviated = "";
            this.navigatorEx1.UpdateSqlList = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.UpdateSqlList")));
            this.navigatorEx1.Load += new System.EventHandler(this.navigatorEx1_Load);
            // 
            // statusStripBarEx1
            // 
            this.statusStripBarEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusStripBarEx1.IsBusy = false;
            this.statusStripBarEx1.Location = new System.Drawing.Point(0, 464);
            this.statusStripBarEx1.Name = "statusStripBarEx1";
            this.statusStripBarEx1.Size = new System.Drawing.Size(680, 22);
            this.statusStripBarEx1.TabIndex = 1;
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.dataGridViewEx1);
            this.panelEx1.Controls.Add(this.treeViewGrid1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 30);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(680, 434);
            this.panelEx1.TabIndex = 2;
            this.panelEx1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEx1_Paint);
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            orm2.ColumnCommPropertyList = "";
            orm2.DelSqlTemplate = "";
            orm2.InsertSqlTemplate = "";
            orm2.PrimaryTable = "";
            orm2.SelectSqlTemplate = "";
            orm2.UpdateSqlTemplate = "";
            this.dataGridViewEx1.DBORM = orm2;
            this.dataGridViewEx1.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.dataGridViewEx1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.NeedReceIveValue = false;
            this.dataGridViewEx1.OperationMode = "";
            this.dataGridViewEx1.PkCellIndex = 0;
            this.dataGridViewEx1.ReceiveValueColumnIndex = -1;
            this.dataGridViewEx1.RelationDataGridView = null;
            this.dataGridViewEx1.RelationDataGridViewColumnIndexList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.RelationDataGridViewColumnIndexList")));
            this.dataGridViewEx1.RelationDataGridViewQuerySql = "";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(680, 97);
            this.dataGridViewEx1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // treeViewGrid1
            // 
            this.treeViewGrid1.ExpandColumn = 0;
            this.treeViewGrid1.ExpandFlag = "[-]";
            this.treeViewGrid1.FoldFlag = "[+]";
            this.treeViewGrid1.HeaderStyle = dataGridViewCellStyle2;
            this.treeViewGrid1.Location = new System.Drawing.Point(200, 147);
            this.treeViewGrid1.Name = "treeViewGrid1";
            this.treeViewGrid1.RowTemplate.Height = 20;
            this.treeViewGrid1.Size = new System.Drawing.Size(240, 150);
            this.treeViewGrid1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.treeViewGrid1.StateCommon.DataCell.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.treeViewGrid1.StateCommon.DataCell.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.treeViewGrid1.StateSelected.DataCell.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.treeViewGrid1.StateSelected.DataCell.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.treeViewGrid1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 486);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.statusStripBarEx1);
            this.Controls.Add(this.navigatorEx1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Mes.ControlsEx.NavigatorEx navigatorEx1;
        private Mes.ControlsEx.StatusStripBarEx statusStripBarEx1;
        private Mes.ControlsEx.PanelEx panelEx1;
        private Mes.ControlsEx.TreeViewGrid treeViewGrid1;
        private Mes.ControlsEx.DataGridViewEx dataGridViewEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;


    }
}