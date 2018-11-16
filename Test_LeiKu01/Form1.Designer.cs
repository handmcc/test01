namespace Test_LeiKu01
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Mes.ControlsEx.Class.ORM orm2 = new Mes.ControlsEx.Class.ORM();
            System.Windows.Forms.WindowsFormsSynchronizationContext windowsFormsSynchronizationContext2 = new System.Windows.Forms.WindowsFormsSynchronizationContext();
            this.buttonEx1 = new Mes.ControlsEx.ButtonEx(this.components);
            this.EMPLOYEE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEx1 = new Mes.ControlsEx.DataGridViewEx(this.components);
            this.navigatorEx1 = new Mes.ControlsEx.NavigatorEx();
            this.comboBoxEx1 = new Mes.ControlsEx.ComboBoxEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEx1
            // 
            this.buttonEx1.Location = new System.Drawing.Point(66, 262);
            this.buttonEx1.Name = "buttonEx1";
            this.buttonEx1.Size = new System.Drawing.Size(90, 25);
            this.buttonEx1.TabIndex = 0;
            this.buttonEx1.Values.Text = "查询";
            this.buttonEx1.Click += new System.EventHandler(this.buttonEx1_Click);
            // 
            // EMPLOYEE_ID
            // 
            this.EMPLOYEE_ID.HeaderText = "员工编号";
            this.EMPLOYEE_ID.Name = "EMPLOYEE_ID";
            // 
            // NAME
            // 
            this.NAME.HeaderText = "员工姓名";
            this.NAME.Name = "NAME";
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
            orm2.ColumnCommPropertyList = "";
            orm2.DelSqlTemplate = "";
            orm2.InsertSqlTemplate = "";
            orm2.PrimaryTable = "";
            orm2.SelectSqlTemplate = "";
            orm2.UpdateSqlTemplate = "";
            this.dataGridViewEx1.DBORM = orm2;
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
            this.dataGridViewEx1.Location = new System.Drawing.Point(-1, 32);
            this.dataGridViewEx1.Name = "dataGridViewEx1";
            this.dataGridViewEx1.NeedReceIveValue = false;
            this.dataGridViewEx1.OperationMode = "";
            this.dataGridViewEx1.PkCellIndex = 0;
            this.dataGridViewEx1.ReceiveValueColumnIndex = -1;
            this.dataGridViewEx1.RelationDataGridView = null;
            this.dataGridViewEx1.RelationDataGridViewColumnIndexList = ((System.Collections.Generic.List<int>)(resources.GetObject("dataGridViewEx1.RelationDataGridViewColumnIndexList")));
            this.dataGridViewEx1.RelationDataGridViewQuerySql = "";
            this.dataGridViewEx1.RowTemplate.Height = 23;
            this.dataGridViewEx1.Size = new System.Drawing.Size(462, 210);
            this.dataGridViewEx1.TabIndex = 1;
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
            this.navigatorEx1.ShowChooseAllBtn = false;
            this.navigatorEx1.ShowClearBtn = false;
            this.navigatorEx1.ShowDelBtn = false;
            this.navigatorEx1.ShowDetailBtn = false;
            this.navigatorEx1.ShowQueryBtn = true;
            this.navigatorEx1.ShowSaveBtn = true;
            this.navigatorEx1.Size = new System.Drawing.Size(462, 30);
            this.navigatorEx1.SqlExecuteResult = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.SqlExecuteResult")));
            this.navigatorEx1.TabIndex = 2;
            this.navigatorEx1.TbAbbreviated = "";
            this.navigatorEx1.UpdateSqlList = ((System.Collections.Generic.List<string>)(resources.GetObject("navigatorEx1.UpdateSqlList")));
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.AlwaysActive = false;
            this.comboBoxEx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEx1.DropDownWidth = 121;
            this.comboBoxEx1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxEx1.InitFastCodeOrSql = "";
            this.comboBoxEx1.InitType = Mes.Core.ApplicationObject.ComboBoxInitType.NONE;
            this.comboBoxEx1.Location = new System.Drawing.Point(184, 266);
            this.comboBoxEx1.MustBeInput = false;
            this.comboBoxEx1.MustBeInputErrorMsg = "";
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.OperationStatus = Mes.Core.ApplicationObject.OperationStatus.NONE;
            this.comboBoxEx1.RangeEndValue = "";
            this.comboBoxEx1.RangeStartValue = "";
            this.comboBoxEx1.RegString = "";
            this.comboBoxEx1.RelatedLable = null;
            this.comboBoxEx1.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEx1.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.Red;
            this.comboBoxEx1.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboBoxEx1.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.comboBoxEx1.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.comboBoxEx1.TabIndex = 3;
            this.comboBoxEx1.ValidationErrorMsg = "";
            this.comboBoxEx1.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 366);
            this.Controls.Add(this.comboBoxEx1);
            this.Controls.Add(this.navigatorEx1);
            this.Controls.Add(this.dataGridViewEx1);
            this.Controls.Add(this.buttonEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Mes.ControlsEx.ButtonEx buttonEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private Mes.ControlsEx.DataGridViewEx dataGridViewEx1;
        private Mes.ControlsEx.NavigatorEx navigatorEx1;
        private Mes.ControlsEx.ComboBoxEx comboBoxEx1;

    }
}

