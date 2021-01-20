namespace ScrumTaskBoard
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.tbxTName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tbxDesc = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbxNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Calculate = new DevExpress.XtraEditors.SimpleButton();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.dateEstim = new DevExpress.XtraEditors.DateEdit();
            this.tbxPname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tbxUName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbxImp = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dateFinsh = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxTName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEstim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEstim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinsh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinsh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxTName
            // 
            this.tbxTName.Location = new System.Drawing.Point(158, 36);
            this.tbxTName.Name = "tbxTName";
            this.tbxTName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbxTName.Properties.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tbxTName.Properties.Appearance.Options.UseBackColor = true;
            this.tbxTName.Properties.Appearance.Options.UseFont = true;
            this.tbxTName.Properties.Appearance.Options.UseForeColor = true;
            this.tbxTName.Size = new System.Drawing.Size(200, 20);
            this.tbxTName.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Location = new System.Drawing.Point(74, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Task Name";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Location = new System.Drawing.Point(18, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Task Description";
            // 
            // tbxDesc
            // 
            this.tbxDesc.EditValue = "Description";
            this.tbxDesc.Location = new System.Drawing.Point(18, 102);
            this.tbxDesc.Name = "tbxDesc";
            this.tbxDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbxDesc.Properties.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDesc.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tbxDesc.Properties.Appearance.Options.UseBackColor = true;
            this.tbxDesc.Properties.Appearance.Options.UseFont = true;
            this.tbxDesc.Properties.Appearance.Options.UseForeColor = true;
            this.tbxDesc.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.tbxDesc.Properties.AppearanceDisabled.Options.UseFont = true;
            this.tbxDesc.Size = new System.Drawing.Size(350, 133);
            this.tbxDesc.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(458, 80);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Task Note";
            // 
            // tbxNote
            // 
            this.tbxNote.EditValue = "Note";
            this.tbxNote.Location = new System.Drawing.Point(458, 102);
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbxNote.Properties.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNote.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tbxNote.Properties.Appearance.Options.UseBackColor = true;
            this.tbxNote.Properties.Appearance.Options.UseFont = true;
            this.tbxNote.Properties.Appearance.Options.UseForeColor = true;
            this.tbxNote.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline);
            this.tbxNote.Properties.AppearanceDisabled.Options.UseFont = true;
            this.tbxNote.Size = new System.Drawing.Size(363, 133);
            this.tbxNote.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Location = new System.Drawing.Point(54, 291);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(120, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Task Start Date";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.Location = new System.Drawing.Point(458, 269);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(168, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Estimated Finish Date";
            // 
            // Calculate
            // 
            this.Calculate.Appearance.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Calculate.Appearance.Options.UseFont = true;
            this.Calculate.Appearance.Options.UseForeColor = true;
            this.Calculate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Calculate.ImageOptions.SvgImage")));
            this.Calculate.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.Calculate.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.Calculate.Location = new System.Drawing.Point(685, 285);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(125, 23);
            this.Calculate.TabIndex = 12;
            this.Calculate.Text = "Calculate Date";
            // 
            // dateStart
            // 
            this.dateStart.EditValue = null;
            this.dateStart.Enabled = false;
            this.dateStart.Location = new System.Drawing.Point(186, 288);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dateStart.Properties.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.dateStart.Properties.Appearance.Options.UseBackColor = true;
            this.dateStart.Properties.Appearance.Options.UseFont = true;
            this.dateStart.Properties.Appearance.Options.UseForeColor = true;
            this.dateStart.Properties.BeepOnError = false;
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateStart.Properties.DisplayFormat.FormatString = "";
            this.dateStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Properties.EditFormat.FormatString = "";
            this.dateStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateStart.Properties.MaskSettings.Set("mask", "yyyy-mm-d");
            this.dateStart.Properties.NullDateCalendarValue = new System.DateTime(2021, 1, 21, 0, 24, 53, 0);
            this.dateStart.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 9;
            // 
            // dateEstim
            // 
            this.dateEstim.EditValue = null;
            this.dateEstim.Enabled = false;
            this.dateEstim.Location = new System.Drawing.Point(458, 288);
            this.dateEstim.Name = "dateEstim";
            this.dateEstim.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dateEstim.Properties.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEstim.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.dateEstim.Properties.Appearance.Options.UseBackColor = true;
            this.dateEstim.Properties.Appearance.Options.UseFont = true;
            this.dateEstim.Properties.Appearance.Options.UseForeColor = true;
            this.dateEstim.Properties.BeepOnError = false;
            this.dateEstim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEstim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEstim.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateEstim.Properties.DisplayFormat.FormatString = "";
            this.dateEstim.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEstim.Properties.EditFormat.FormatString = "";
            this.dateEstim.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEstim.Properties.MaskSettings.Set("mask", "yyyy-mm-d");
            this.dateEstim.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEstim.Size = new System.Drawing.Size(200, 20);
            this.dateEstim.TabIndex = 11;
            // 
            // tbxPname
            // 
            this.tbxPname.Enabled = false;
            this.tbxPname.Location = new System.Drawing.Point(579, 36);
            this.tbxPname.Name = "tbxPname";
            this.tbxPname.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbxPname.Properties.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPname.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tbxPname.Properties.Appearance.Options.UseBackColor = true;
            this.tbxPname.Properties.Appearance.Options.UseFont = true;
            this.tbxPname.Properties.Appearance.Options.UseForeColor = true;
            this.tbxPname.Size = new System.Drawing.Size(200, 20);
            this.tbxPname.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Location = new System.Drawing.Point(458, 39);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(104, 13);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Project  Name";
            // 
            // tbxUName
            // 
            this.tbxUName.Location = new System.Drawing.Point(186, 372);
            this.tbxUName.Name = "tbxUName";
            this.tbxUName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.tbxUName.Properties.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.tbxUName.Properties.Appearance.Options.UseBackColor = true;
            this.tbxUName.Properties.Appearance.Options.UseFont = true;
            this.tbxUName.Properties.Appearance.Options.UseForeColor = true;
            this.tbxUName.Size = new System.Drawing.Size(200, 20);
            this.tbxUName.TabIndex = 16;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.Location = new System.Drawing.Point(102, 375);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "User Name";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl8.Location = new System.Drawing.Point(54, 334);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(120, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Task İmportance";
            // 
            // cbxImp
            // 
            this.cbxImp.EditValue = "";
            this.cbxImp.Location = new System.Drawing.Point(186, 331);
            this.cbxImp.Name = "cbxImp";
            this.cbxImp.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.cbxImp.Properties.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxImp.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cbxImp.Properties.Appearance.Options.UseBackColor = true;
            this.cbxImp.Properties.Appearance.Options.UseFont = true;
            this.cbxImp.Properties.Appearance.Options.UseForeColor = true;
            this.cbxImp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxImp.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("easy"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("medium"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("hard"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("extreme")});
            this.cbxImp.Size = new System.Drawing.Size(200, 20);
            this.cbxImp.TabIndex = 18;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Gold;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton1.Location = new System.Drawing.Point(344, 443);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(125, 23);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "Update";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.Gold;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.simpleButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton2.Location = new System.Drawing.Point(158, 443);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(125, 23);
            this.simpleButton2.TabIndex = 20;
            this.simpleButton2.Text = "Add New";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.Gold;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButton3.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette;
            this.simpleButton3.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.simpleButton3.Location = new System.Drawing.Point(533, 443);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(125, 23);
            this.simpleButton3.TabIndex = 21;
            this.simpleButton3.Text = "Delete";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl9.Location = new System.Drawing.Point(458, 321);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(88, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Finish Date";
            // 
            // dateFinsh
            // 
            this.dateFinsh.EditValue = null;
            this.dateFinsh.Enabled = false;
            this.dateFinsh.Location = new System.Drawing.Point(458, 340);
            this.dateFinsh.Name = "dateFinsh";
            this.dateFinsh.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dateFinsh.Properties.Appearance.Font = new System.Drawing.Font("SimSun-ExtB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinsh.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.dateFinsh.Properties.Appearance.Options.UseBackColor = true;
            this.dateFinsh.Properties.Appearance.Options.UseFont = true;
            this.dateFinsh.Properties.Appearance.Options.UseForeColor = true;
            this.dateFinsh.Properties.BeepOnError = false;
            this.dateFinsh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFinsh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFinsh.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.dateFinsh.Properties.DisplayFormat.FormatString = "";
            this.dateFinsh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateFinsh.Properties.EditFormat.FormatString = "";
            this.dateFinsh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateFinsh.Properties.MaskSettings.Set("mask", "yyyy-mm-d");
            this.dateFinsh.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateFinsh.Size = new System.Drawing.Size(200, 20);
            this.dateFinsh.TabIndex = 23;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 568);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.dateFinsh);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.tbxUName);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.tbxPname);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tbxNote);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tbxTName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tbxDesc);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.dateEstim);
            this.Controls.Add(this.cbxImp);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(870, 600);
            this.MinimumSize = new System.Drawing.Size(870, 600);
            this.Name = "TaskForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbxTName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEstim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEstim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxPname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxUName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinsh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinsh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit tbxTName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.MemoEdit tbxDesc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit tbxNote;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton Calculate;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.DateEdit dateEstim;
        private DevExpress.XtraEditors.TextEdit tbxPname;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit tbxUName;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cbxImp;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.DateEdit dateFinsh;
    }
}