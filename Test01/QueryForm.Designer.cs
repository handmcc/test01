namespace Test01
{
    partial class QueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            this.panelEx1 = new Mes.ControlsEx.PanelEx(this.components);
            this.lableEx4 = new Mes.ControlsEx.LableEx(this.components);
            this.calendar2 = new Mes.ControlsEx.Calendar();
            this.tbCreationEnd = new Mes.ControlsEx.TextBoxEx(this.components);
            this.tbCreationStart = new Mes.ControlsEx.TextBoxEx(this.components);
            this.calendar1 = new Mes.ControlsEx.Calendar();
            this.lovButtonEx2 = new Mes.ControlsEx.LovButtonEx(this.components);
            this.lableEx3 = new Mes.ControlsEx.LableEx(this.components);
            this.lovButtonEx1 = new Mes.ControlsEx.LovButtonEx(this.components);
            this.tbItemNo = new Mes.ControlsEx.TextBoxEx(this.components);
            this.lableEx2 = new Mes.ControlsEx.LableEx(this.components);
            this.tbPlantId = new Mes.ControlsEx.TextBoxEx(this.components);
            this.lableEx1 = new Mes.ControlsEx.LableEx(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.AutoScroll = true;
            this.panelEx1.Controls.Add(this.lableEx4);
            this.panelEx1.Controls.Add(this.calendar2);
            this.panelEx1.Controls.Add(this.tbCreationEnd);
            this.panelEx1.Controls.Add(this.tbCreationStart);
            this.panelEx1.Controls.Add(this.calendar1);
            this.panelEx1.Controls.Add(this.lovButtonEx2);
            this.panelEx1.Controls.Add(this.lableEx3);
            this.panelEx1.Controls.Add(this.lovButtonEx1);
            this.panelEx1.Controls.Add(this.tbItemNo);
            this.panelEx1.Controls.Add(this.lableEx2);
            this.panelEx1.Controls.Add(this.tbPlantId);
            this.panelEx1.Controls.Add(this.lableEx1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 25);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(573, 176);
            this.panelEx1.TabIndex = 3;
            // 
            // lableEx4
            // 
            this.lableEx4.AutoSize = false;
            this.lableEx4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lableEx4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx4.Location = new System.Drawing.Point(317, 100);
            this.lableEx4.Name = "lableEx4";
            this.lableEx4.Size = new System.Drawing.Size(46, 23);
            this.lableEx4.Text = "至";
            this.lableEx4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calendar2
            // 
            this.calendar2.BackColor = System.Drawing.Color.Transparent;
            this.calendar2.BindName = this.tbCreationEnd;
            this.calendar2.EndDate = this.tbCreationEnd;
            this.calendar2.Location = new System.Drawing.Point(476, 102);
            this.calendar2.Name = "calendar2";
            this.calendar2.ReturnDate = null;
            this.calendar2.ShowTimePicker = true;
            this.calendar2.Size = new System.Drawing.Size(24, 24);
            this.calendar2.StartDate = this.tbCreationStart;
            this.calendar2.TabIndex = 12;
            // 
            // tbCreationEnd
            // 
            this.tbCreationEnd.AlwaysActive = false;
            this.tbCreationEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbCreationEnd.IsAutoChangeColorBy = true;
            this.tbCreationEnd.IsMultirow = false;
            this.tbCreationEnd.Location = new System.Drawing.Point(370, 102);
            this.tbCreationEnd.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbCreationEnd.LovFormReturnValue")));
            this.tbCreationEnd.MultirowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbCreationEnd.MultirowValue")));
            this.tbCreationEnd.MustBeInput = false;
            this.tbCreationEnd.MustBeInputErrorMsg = "";
            this.tbCreationEnd.Name = "tbCreationEnd";
            this.tbCreationEnd.OperationStatus = Mes.Core.ApplicationObject.OperationStatus.NONE;
            this.tbCreationEnd.RangeEndValue = "";
            this.tbCreationEnd.RangeStartValue = "";
            this.tbCreationEnd.ReadOnly = true;
            this.tbCreationEnd.realValue = "";
            this.tbCreationEnd.RegString = "";
            this.tbCreationEnd.RelatedLable = null;
            this.tbCreationEnd.Size = new System.Drawing.Size(100, 22);
            this.tbCreationEnd.StateActive.Border.Color1 = System.Drawing.Color.Red;
            this.tbCreationEnd.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbCreationEnd.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbCreationEnd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbCreationEnd.StateCommon.Border.Rounding = 2;
            this.tbCreationEnd.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbCreationEnd.TabIndex = 11;
            this.tbCreationEnd.TabStop = false;
            this.tbCreationEnd.TextChangedByInput = false;
            this.tbCreationEnd.ValidationErrorMsg = "";
            this.tbCreationEnd.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // tbCreationStart
            // 
            this.tbCreationStart.AlwaysActive = false;
            this.tbCreationStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbCreationStart.IsAutoChangeColorBy = true;
            this.tbCreationStart.IsMultirow = false;
            this.tbCreationStart.Location = new System.Drawing.Point(131, 101);
            this.tbCreationStart.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbCreationStart.LovFormReturnValue")));
            this.tbCreationStart.MultirowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbCreationStart.MultirowValue")));
            this.tbCreationStart.MustBeInput = false;
            this.tbCreationStart.MustBeInputErrorMsg = "";
            this.tbCreationStart.Name = "tbCreationStart";
            this.tbCreationStart.OperationStatus = Mes.Core.ApplicationObject.OperationStatus.NONE;
            this.tbCreationStart.RangeEndValue = "";
            this.tbCreationStart.RangeStartValue = "";
            this.tbCreationStart.ReadOnly = true;
            this.tbCreationStart.realValue = "";
            this.tbCreationStart.RegString = "";
            this.tbCreationStart.RelatedLable = null;
            this.tbCreationStart.Size = new System.Drawing.Size(100, 22);
            this.tbCreationStart.StateActive.Border.Color1 = System.Drawing.Color.Red;
            this.tbCreationStart.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbCreationStart.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbCreationStart.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbCreationStart.StateCommon.Border.Rounding = 2;
            this.tbCreationStart.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbCreationStart.TabIndex = 10;
            this.tbCreationStart.TabStop = false;
            this.tbCreationStart.TextChangedByInput = false;
            this.tbCreationStart.ValidationErrorMsg = "";
            this.tbCreationStart.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // calendar1
            // 
            this.calendar1.BackColor = System.Drawing.Color.Transparent;
            this.calendar1.BindName = this.tbCreationStart;
            this.calendar1.EndDate = this.tbCreationEnd;
            this.calendar1.Location = new System.Drawing.Point(243, 100);
            this.calendar1.Name = "calendar1";
            this.calendar1.ReturnDate = null;
            this.calendar1.ShowTimePicker = true;
            this.calendar1.Size = new System.Drawing.Size(24, 24);
            this.calendar1.StartDate = this.tbCreationStart;
            this.calendar1.TabIndex = 9;
            // 
            // lovButtonEx2
            // 
            this.lovButtonEx2.CancelPopUp = false;
            this.lovButtonEx2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lovButtonEx2.Location = new System.Drawing.Point(476, 44);
            this.lovButtonEx2.LovParameter = null;
            this.lovButtonEx2.Name = "lovButtonEx2";
            this.lovButtonEx2.RunInPlatform = Mes.Core.ApplicationObject.Platform.PC;
            this.lovButtonEx2.Size = new System.Drawing.Size(30, 30);
            this.lovButtonEx2.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.lovButtonEx2.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.lovButtonEx2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lovButtonEx2.TabIndex = 8;
            this.lovButtonEx2.TargetTextBox = null;
            this.lovButtonEx2.Values.Image = ((System.Drawing.Image)(resources.GetObject("lovButtonEx2.Values.Image")));
            this.lovButtonEx2.Values.Text = "";
            this.lovButtonEx2.Click += new System.EventHandler(this.lovButtonEx2_Click);
            // 
            // lableEx3
            // 
            this.lableEx3.AutoSize = false;
            this.lableEx3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lableEx3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx3.Location = new System.Drawing.Point(264, 42);
            this.lableEx3.Name = "lableEx3";
            this.lableEx3.Size = new System.Drawing.Size(100, 23);
            this.lableEx3.Text = "物料";
            this.lableEx3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lovButtonEx1
            // 
            this.lovButtonEx1.CancelPopUp = false;
            this.lovButtonEx1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lovButtonEx1.Location = new System.Drawing.Point(237, 42);
            this.lovButtonEx1.LovParameter = null;
            this.lovButtonEx1.Name = "lovButtonEx1";
            this.lovButtonEx1.RunInPlatform = Mes.Core.ApplicationObject.Platform.PC;
            this.lovButtonEx1.Size = new System.Drawing.Size(30, 30);
            this.lovButtonEx1.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.lovButtonEx1.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.lovButtonEx1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.lovButtonEx1.TabIndex = 5;
            this.lovButtonEx1.TargetTextBox = null;
            this.lovButtonEx1.Values.Image = ((System.Drawing.Image)(resources.GetObject("lovButtonEx1.Values.Image")));
            this.lovButtonEx1.Values.Text = "";
            // 
            // tbItemNo
            // 
            this.tbItemNo.AlwaysActive = false;
            this.tbItemNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbItemNo.IsAutoChangeColorBy = true;
            this.tbItemNo.IsMultirow = false;
            this.tbItemNo.Location = new System.Drawing.Point(370, 44);
            this.tbItemNo.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbItemNo.LovFormReturnValue")));
            this.tbItemNo.MultirowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbItemNo.MultirowValue")));
            this.tbItemNo.MustBeInput = false;
            this.tbItemNo.MustBeInputErrorMsg = "";
            this.tbItemNo.Name = "tbItemNo";
            this.tbItemNo.OperationStatus = Mes.Core.ApplicationObject.OperationStatus.NONE;
            this.tbItemNo.RangeEndValue = "";
            this.tbItemNo.RangeStartValue = "";
            this.tbItemNo.realValue = "";
            this.tbItemNo.RegString = "";
            this.tbItemNo.RelatedLable = null;
            this.tbItemNo.Size = new System.Drawing.Size(100, 22);
            this.tbItemNo.StateActive.Border.Color1 = System.Drawing.Color.Red;
            this.tbItemNo.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbItemNo.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbItemNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbItemNo.StateCommon.Border.Rounding = 2;
            this.tbItemNo.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbItemNo.TabIndex = 4;
            this.tbItemNo.TextChangedByInput = false;
            this.tbItemNo.ValidationErrorMsg = "";
            this.tbItemNo.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // lableEx2
            // 
            this.lableEx2.AutoSize = false;
            this.lableEx2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lableEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx2.Location = new System.Drawing.Point(24, 100);
            this.lableEx2.Name = "lableEx2";
            this.lableEx2.Size = new System.Drawing.Size(100, 23);
            this.lableEx2.Text = "生产日期从";
            this.lableEx2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPlantId
            // 
            this.tbPlantId.AlwaysActive = false;
            this.tbPlantId.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbPlantId.IsAutoChangeColorBy = true;
            this.tbPlantId.IsMultirow = false;
            this.tbPlantId.Location = new System.Drawing.Point(131, 44);
            this.tbPlantId.LovFormReturnValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbPlantId.LovFormReturnValue")));
            this.tbPlantId.MultirowValue = ((System.Collections.Generic.List<string>)(resources.GetObject("tbPlantId.MultirowValue")));
            this.tbPlantId.MustBeInput = false;
            this.tbPlantId.MustBeInputErrorMsg = "";
            this.tbPlantId.Name = "tbPlantId";
            this.tbPlantId.OperationStatus = Mes.Core.ApplicationObject.OperationStatus.NONE;
            this.tbPlantId.RangeEndValue = "";
            this.tbPlantId.RangeStartValue = "";
            this.tbPlantId.realValue = "";
            this.tbPlantId.RegString = "";
            this.tbPlantId.RelatedLable = null;
            this.tbPlantId.Size = new System.Drawing.Size(100, 22);
            this.tbPlantId.StateActive.Border.Color1 = System.Drawing.Color.Red;
            this.tbPlantId.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPlantId.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbPlantId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPlantId.StateCommon.Border.Rounding = 2;
            this.tbPlantId.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbPlantId.TabIndex = 1;
            this.tbPlantId.TextChangedByInput = false;
            this.tbPlantId.ValidationErrorMsg = "";
            this.tbPlantId.ValidationType = Mes.Core.ApplicationObject.DataGridViewColumnValidationType.NONE;
            // 
            // lableEx1
            // 
            this.lableEx1.AutoSize = false;
            this.lableEx1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lableEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lableEx1.Location = new System.Drawing.Point(25, 43);
            this.lableEx1.Name = "lableEx1";
            this.lableEx1.Size = new System.Drawing.Size(100, 23);
            this.lableEx1.Text = "工厂";
            this.lableEx1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 201);
            this.Controls.Add(this.panelEx1);
            this.Name = "QueryForm";
            this.TabText = "小条码查询";
            this.Text = "小条码查询";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.Controls.SetChildIndex(this.panelEx1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelEx1)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mes.ControlsEx.PanelEx panelEx1;
        private Mes.ControlsEx.LableEx lableEx2;
        private Mes.ControlsEx.TextBoxEx tbPlantId;
        private Mes.ControlsEx.LableEx lableEx1;
        private Mes.ControlsEx.LableEx lableEx3;
        private Mes.ControlsEx.LovButtonEx lovButtonEx1;
        private Mes.ControlsEx.TextBoxEx tbItemNo;
        private Mes.ControlsEx.Calendar calendar1;
        private Mes.ControlsEx.LovButtonEx lovButtonEx2;
        private Mes.ControlsEx.TextBoxEx tbCreationStart;
        private Mes.ControlsEx.LableEx lableEx4;
        private Mes.ControlsEx.Calendar calendar2;
        private Mes.ControlsEx.TextBoxEx tbCreationEnd;
    }
}