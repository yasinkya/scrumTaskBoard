namespace ScrumTaskBoard
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.DesingFormCont = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.TodoPanel = new DevExpress.XtraEditors.PanelControl();
            this.toDoGroup = new DevExpress.XtraEditors.GroupControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.slideControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.tasksElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.addBtn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.moveBtn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.editBtn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.deleteBtn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.userElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.userInfoBtn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.logOutBtn = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.projectElements = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSeparator3 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
            this.DesingFormCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodoPanel)).BeginInit();
            this.TodoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDoGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // DesingFormCont
            // 
            this.DesingFormCont.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DesingFormCont.Appearance.Options.UseBackColor = true;
            this.DesingFormCont.Controls.Add(this.TodoPanel);
            this.DesingFormCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesingFormCont.Location = new System.Drawing.Point(212, 27);
            this.DesingFormCont.Margin = new System.Windows.Forms.Padding(4);
            this.DesingFormCont.Name = "DesingFormCont";
            this.DesingFormCont.Size = new System.Drawing.Size(1508, 951);
            this.DesingFormCont.TabIndex = 0;
            this.DesingFormCont.Click += new System.EventHandler(this.fluentDesignFormContainer1_Click);
            // 
            // TodoPanel
            // 
            this.TodoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TodoPanel.Appearance.Options.UseBackColor = true;
            this.TodoPanel.AutoSize = true;
            this.TodoPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.TodoPanel.Controls.Add(this.toDoGroup);
            this.TodoPanel.Location = new System.Drawing.Point(60, 10);
            this.TodoPanel.Name = "TodoPanel";
            this.TodoPanel.Size = new System.Drawing.Size(330, 938);
            this.TodoPanel.TabIndex = 2;
            // 
            // toDoGroup
            // 
            this.toDoGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toDoGroup.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toDoGroup.Appearance.Options.UseBackColor = true;
            this.toDoGroup.AutoSize = true;
            this.toDoGroup.CaptionImageOptions.Location = DevExpress.Utils.GroupElementLocation.BeforeText;
            this.toDoGroup.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("toDoGroup.CaptionImageOptions.SvgImage")));
            this.toDoGroup.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.toDoGroup.Location = new System.Drawing.Point(5, 5);
            this.toDoGroup.Name = "toDoGroup";
            this.toDoGroup.Size = new System.Drawing.Size(321, 41);
            this.toDoGroup.TabIndex = 0;
            this.toDoGroup.Text = "                                    To Do         ";
            this.toDoGroup.Paint += new System.Windows.Forms.PaintEventHandler(this.toDoGroup_Paint);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            // 
            // slideControl
            // 
            this.slideControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.slideControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.tasksElement,
            this.accordionControlSeparator1,
            this.userElement,
            this.accordionControlSeparator2,
            this.projectElements,
            this.accordionControlSeparator3});
            this.slideControl.Location = new System.Drawing.Point(0, 27);
            this.slideControl.Margin = new System.Windows.Forms.Padding(4);
            this.slideControl.Name = "slideControl";
            this.slideControl.OptionsHamburgerMenu.DisplayMode = DevExpress.XtraBars.Navigation.AccordionControlDisplayMode.Minimal;
            this.slideControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.slideControl.Size = new System.Drawing.Size(212, 951);
            this.slideControl.TabIndex = 1;
            this.slideControl.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // tasksElement
            // 
            this.tasksElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.addBtn,
            this.moveBtn,
            this.editBtn,
            this.deleteBtn});
            this.tasksElement.Name = "tasksElement";
            this.tasksElement.Text = "Tasks";
            this.tasksElement.Click += new System.EventHandler(this.accordionControlElement4_Click);
            // 
            // addBtn
            // 
            this.addBtn.Name = "addBtn";
            this.addBtn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.accordionControlElement5_Click);
            // 
            // moveBtn
            // 
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.moveBtn.Text = "Move";
            // 
            // editBtn
            // 
            this.editBtn.Name = "editBtn";
            this.editBtn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.editBtn.Text = "Edit";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.deleteBtn.Text = "Delete";
            // 
            // accordionControlSeparator1
            // 
            this.accordionControlSeparator1.Name = "accordionControlSeparator1";
            // 
            // userElement
            // 
            this.userElement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.userInfoBtn,
            this.logOutBtn});
            this.userElement.Expanded = true;
            this.userElement.Name = "userElement";
            this.userElement.Text = "User";
            // 
            // userInfoBtn
            // 
            this.userInfoBtn.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.userInfoBtn.Name = "userInfoBtn";
            this.userInfoBtn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.userInfoBtn.Text = "User Info";
            // 
            // logOutBtn
            // 
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.logOutBtn.Text = "Log Out";
            // 
            // accordionControlSeparator2
            // 
            this.accordionControlSeparator2.Name = "accordionControlSeparator2";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(4);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1720, 27);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // projectElements
            // 
            this.projectElements.Expanded = true;
            this.projectElements.Name = "projectElements";
            this.projectElements.Text = "Projects";
            this.projectElements.Click += new System.EventHandler(this.prokectElements_Click);
            // 
            // accordionControlSeparator3
            // 
            this.accordionControlSeparator3.Name = "accordionControlSeparator3";
            // 
            // MainScreen
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 978);
            this.ControlContainer = this.DesingFormCont;
            this.Controls.Add(this.DesingFormCont);
            this.Controls.Add(this.slideControl);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MainScreen.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "MainScreen";
            this.NavigationControl = this.slideControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.DesingFormCont.ResumeLayout(false);
            this.DesingFormCont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodoPanel)).EndInit();
            this.TodoPanel.ResumeLayout(false);
            this.TodoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDoGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slideControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer DesingFormCont;
        private DevExpress.XtraBars.Navigation.AccordionControl slideControl;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement tasksElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement addBtn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement moveBtn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement editBtn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement deleteBtn;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement userElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement userInfoBtn;
        private DevExpress.XtraBars.Navigation.AccordionControlElement logOutBtn;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
        private DevExpress.XtraEditors.GroupControl toDoGroup;
        private DevExpress.XtraEditors.PanelControl TodoPanel;
        private DevExpress.XtraBars.Navigation.AccordionControlElement projectElements;
        private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator3;
    }
}