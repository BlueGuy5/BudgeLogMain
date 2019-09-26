namespace BudgeLogMain
{
    partial class Form1
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
            Syncfusion.Windows.Forms.Tools.SplitButtonRenderer splitButtonRenderer1 = new Syncfusion.Windows.Forms.Tools.SplitButtonRenderer();
            this.splitButton_Vendor = new Syncfusion.Windows.Forms.Tools.SplitButton();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.Grid_BudgetLog = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.budgetLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetAutomateDataSet = new BudgeLogMain.BudgetAutomateDataSet();
            this.budgetLogTableAdapter = new BudgeLogMain.BudgetAutomateDataSetTableAdapters.BudgetLogTableAdapter();
            this.sfSkinManager1 = new Syncfusion.WinForms.Controls.SfSkinManager(this.components);
            this.butt_Rent = new Syncfusion.Windows.Forms.ButtonAdv();
            this.butt_RentalInsurance = new Syncfusion.Windows.Forms.ButtonAdv();
            this.butt_AutoInsurance = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txt_Cost = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.gradientPanelExt1 = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            this.txt_Date = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.butt_Apply = new Syncfusion.Windows.Forms.ButtonAdv();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txt_rent = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txt_AutoInsurance = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txt_RentalInsurance = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lbl_Rent = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lbl_RentalInsurance = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lbl_AutoInsurance = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_BudgetLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetAutomateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).BeginInit();
            this.gradientPanelExt1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AutoInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RentalInsurance)).BeginInit();
            this.SuspendLayout();
            // 
            // splitButton_Vendor
            // 
            this.splitButton_Vendor.BackColor = System.Drawing.SystemColors.Control;
            this.splitButton_Vendor.BeforeTouchSize = new System.Drawing.Size(100, 30);
            this.splitButton_Vendor.DropDownPosition = Syncfusion.Windows.Forms.Tools.Position.Bottom;
            this.splitButton_Vendor.ForeColor = System.Drawing.Color.Black;
            this.splitButton_Vendor.Location = new System.Drawing.Point(34, 100);
            this.splitButton_Vendor.MinimumSize = new System.Drawing.Size(75, 23);
            this.splitButton_Vendor.Name = "splitButton_Vendor";
            splitButtonRenderer1.SplitButton = this.splitButton_Vendor;
            this.splitButton_Vendor.Renderer = splitButtonRenderer1;
            this.splitButton_Vendor.ShowDropDownOnButtonClick = false;
            this.splitButton_Vendor.Size = new System.Drawing.Size(100, 30);
            this.splitButton_Vendor.TabIndex = 4;
            this.splitButton_Vendor.Text = "(Select)";
            this.splitButton_Vendor.ThemeName = "Office2010Blue";
            this.splitButton_Vendor.DropDowItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.splitButton_Vendor_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gradientPanel1.Controls.Add(this.Grid_BudgetLog);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(351, 614);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.ThemeName = "Office2010Blue";
            // 
            // Grid_BudgetLog
            // 
            this.Grid_BudgetLog.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Grid_BudgetLog.ApplyVisualStyles = false;
            this.Grid_BudgetLog.BackColor = System.Drawing.SystemColors.Window;
            this.Grid_BudgetLog.DataSource = this.budgetLogBindingSource;
            this.Grid_BudgetLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_BudgetLog.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2010;
            this.Grid_BudgetLog.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2010Blue;
            this.Grid_BudgetLog.Location = new System.Drawing.Point(0, 0);
            this.Grid_BudgetLog.Name = "Grid_BudgetLog";
            this.Grid_BudgetLog.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.Grid_BudgetLog.Size = new System.Drawing.Size(347, 610);
            this.Grid_BudgetLog.TabIndex = 0;
            this.Grid_BudgetLog.TableOptions.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.Grid_BudgetLog.TableOptions.SelectionTextColor = System.Drawing.SystemColors.HighlightText;
            this.Grid_BudgetLog.Text = "gridGroupingControl1";
            this.Grid_BudgetLog.UseRightToLeftCompatibleTextBox = true;
            this.Grid_BudgetLog.VersionInfo = "17.2460.0.34";
            // 
            // budgetLogBindingSource
            // 
            this.budgetLogBindingSource.DataMember = "BudgetLog";
            this.budgetLogBindingSource.DataSource = this.budgetAutomateDataSet;
            // 
            // budgetAutomateDataSet
            // 
            this.budgetAutomateDataSet.DataSetName = "BudgetAutomateDataSet";
            this.budgetAutomateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetLogTableAdapter
            // 
            this.budgetLogTableAdapter.ClearBeforeFill = true;
            // 
            // sfSkinManager1
            // 
            this.sfSkinManager1.Component = this;
            this.sfSkinManager1.Controls = this;
            this.sfSkinManager1.ThemeName = null;
            this.sfSkinManager1.VisualTheme = Syncfusion.Windows.Forms.VisualTheme.Office2010Blue;
            // 
            // butt_Rent
            // 
            this.butt_Rent.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.butt_Rent.BeforeTouchSize = new System.Drawing.Size(77, 32);
            this.butt_Rent.Location = new System.Drawing.Point(34, 29);
            this.butt_Rent.Name = "butt_Rent";
            this.butt_Rent.Size = new System.Drawing.Size(77, 32);
            this.butt_Rent.TabIndex = 1;
            this.butt_Rent.Text = "Rent";
            this.butt_Rent.ThemeName = "Office2010";
            this.butt_Rent.UseVisualStyle = true;
            this.butt_Rent.Click += new System.EventHandler(this.butt_Rent_Click);
            // 
            // butt_RentalInsurance
            // 
            this.butt_RentalInsurance.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.butt_RentalInsurance.BeforeTouchSize = new System.Drawing.Size(77, 32);
            this.butt_RentalInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butt_RentalInsurance.Location = new System.Drawing.Point(134, 29);
            this.butt_RentalInsurance.Name = "butt_RentalInsurance";
            this.butt_RentalInsurance.Size = new System.Drawing.Size(77, 32);
            this.butt_RentalInsurance.TabIndex = 2;
            this.butt_RentalInsurance.Text = "Rental Insurance";
            this.butt_RentalInsurance.ThemeName = "Office2010";
            this.butt_RentalInsurance.UseVisualStyle = true;
            this.butt_RentalInsurance.Click += new System.EventHandler(this.butt_RentalInsurance_Click);
            // 
            // butt_AutoInsurance
            // 
            this.butt_AutoInsurance.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.butt_AutoInsurance.BeforeTouchSize = new System.Drawing.Size(77, 32);
            this.butt_AutoInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butt_AutoInsurance.Location = new System.Drawing.Point(240, 29);
            this.butt_AutoInsurance.Name = "butt_AutoInsurance";
            this.butt_AutoInsurance.Size = new System.Drawing.Size(77, 32);
            this.butt_AutoInsurance.TabIndex = 3;
            this.butt_AutoInsurance.Text = "Auto Insurance";
            this.butt_AutoInsurance.ThemeName = "Office2010";
            this.butt_AutoInsurance.UseVisualStyle = true;
            this.butt_AutoInsurance.Click += new System.EventHandler(this.butt_AutoInsurance_Click);
            // 
            // txt_Cost
            // 
            this.txt_Cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.txt_Cost.BeforeTouchSize = new System.Drawing.Size(87, 20);
            this.txt_Cost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.txt_Cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txt_Cost.Location = new System.Drawing.Point(151, 100);
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(100, 20);
            this.txt_Cost.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010;
            this.txt_Cost.TabIndex = 5;
            this.txt_Cost.ThemeName = "Office2010";
            // 
            // gradientPanelExt1
            // 
            this.gradientPanelExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.gradientPanelExt1.Border = new System.Windows.Forms.Padding(12);
            this.gradientPanelExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.gradientPanelExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelExt1.Controls.Add(this.txt_Date);
            this.gradientPanelExt1.Controls.Add(this.butt_Apply);
            this.gradientPanelExt1.Controls.Add(this.splitButton_Vendor);
            this.gradientPanelExt1.Controls.Add(this.txt_Cost);
            this.gradientPanelExt1.Controls.Add(this.butt_AutoInsurance);
            this.gradientPanelExt1.Controls.Add(this.butt_RentalInsurance);
            this.gradientPanelExt1.Controls.Add(this.butt_Rent);
            this.gradientPanelExt1.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.gradientPanelExt1.Location = new System.Drawing.Point(361, 262);
            this.gradientPanelExt1.Name = "gradientPanelExt1";
            this.gradientPanelExt1.Size = new System.Drawing.Size(349, 203);
            this.gradientPanelExt1.TabIndex = 6;
            this.gradientPanelExt1.ThemeName = "Office2010Blue";
            // 
            // txt_Date
            // 
            this.txt_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.txt_Date.BeforeTouchSize = new System.Drawing.Size(87, 20);
            this.txt_Date.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.txt_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txt_Date.Location = new System.Drawing.Point(34, 74);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(100, 20);
            this.txt_Date.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010;
            this.txt_Date.TabIndex = 7;
            this.txt_Date.ThemeName = "Office2010";
            // 
            // butt_Apply
            // 
            this.butt_Apply.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2010;
            this.butt_Apply.BeforeTouchSize = new System.Drawing.Size(98, 32);
            this.butt_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.butt_Apply.Location = new System.Drawing.Point(113, 150);
            this.butt_Apply.Name = "butt_Apply";
            this.butt_Apply.Size = new System.Drawing.Size(98, 32);
            this.butt_Apply.TabIndex = 6;
            this.butt_Apply.Text = "Apply";
            this.butt_Apply.ThemeName = "Office2010";
            this.butt_Apply.UseVisualStyle = true;
            this.butt_Apply.Click += new System.EventHandler(this.butt_Apply_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(361, 2);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txt_rent
            // 
            this.txt_rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.txt_rent.BeforeTouchSize = new System.Drawing.Size(87, 20);
            this.txt_rent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.txt_rent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_rent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txt_rent.Location = new System.Drawing.Point(694, 12);
            this.txt_rent.Name = "txt_rent";
            this.txt_rent.Size = new System.Drawing.Size(87, 20);
            this.txt_rent.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010;
            this.txt_rent.TabIndex = 8;
            this.txt_rent.Text = "1000";
            this.txt_rent.ThemeName = "Office2010";
            // 
            // txt_AutoInsurance
            // 
            this.txt_AutoInsurance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.txt_AutoInsurance.BeforeTouchSize = new System.Drawing.Size(87, 20);
            this.txt_AutoInsurance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.txt_AutoInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AutoInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_AutoInsurance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txt_AutoInsurance.Location = new System.Drawing.Point(694, 80);
            this.txt_AutoInsurance.Name = "txt_AutoInsurance";
            this.txt_AutoInsurance.Size = new System.Drawing.Size(87, 20);
            this.txt_AutoInsurance.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010;
            this.txt_AutoInsurance.TabIndex = 9;
            this.txt_AutoInsurance.Text = "75";
            this.txt_AutoInsurance.ThemeName = "Office2010";
            // 
            // txt_RentalInsurance
            // 
            this.txt_RentalInsurance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.txt_RentalInsurance.BeforeTouchSize = new System.Drawing.Size(87, 20);
            this.txt_RentalInsurance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(202)))), ((int)(((byte)(221)))));
            this.txt_RentalInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RentalInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_RentalInsurance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txt_RentalInsurance.Location = new System.Drawing.Point(694, 46);
            this.txt_RentalInsurance.Name = "txt_RentalInsurance";
            this.txt_RentalInsurance.Size = new System.Drawing.Size(87, 20);
            this.txt_RentalInsurance.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2010;
            this.txt_RentalInsurance.TabIndex = 10;
            this.txt_RentalInsurance.Text = "10";
            this.txt_RentalInsurance.ThemeName = "Office2010";
            // 
            // lbl_Rent
            // 
            this.lbl_Rent.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lbl_Rent.BeforeTouchSize = new System.Drawing.Size(95, 20);
            this.lbl_Rent.BorderAppearance = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Rent.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lbl_Rent.Location = new System.Drawing.Point(593, 12);
            this.lbl_Rent.Name = "lbl_Rent";
            this.lbl_Rent.Size = new System.Drawing.Size(95, 20);
            this.lbl_Rent.TabIndex = 11;
            this.lbl_Rent.Text = "Rent";
            this.lbl_Rent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Rent.ThemeName = "Office2010Blue";
            // 
            // lbl_RentalInsurance
            // 
            this.lbl_RentalInsurance.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lbl_RentalInsurance.BeforeTouchSize = new System.Drawing.Size(95, 20);
            this.lbl_RentalInsurance.BorderAppearance = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_RentalInsurance.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lbl_RentalInsurance.Location = new System.Drawing.Point(593, 46);
            this.lbl_RentalInsurance.Name = "lbl_RentalInsurance";
            this.lbl_RentalInsurance.Size = new System.Drawing.Size(95, 20);
            this.lbl_RentalInsurance.TabIndex = 12;
            this.lbl_RentalInsurance.Text = "Rental Insurance";
            this.lbl_RentalInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_RentalInsurance.ThemeName = "Office2010Blue";
            // 
            // lbl_AutoInsurance
            // 
            this.lbl_AutoInsurance.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lbl_AutoInsurance.BeforeTouchSize = new System.Drawing.Size(97, 20);
            this.lbl_AutoInsurance.BorderAppearance = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_AutoInsurance.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lbl_AutoInsurance.Location = new System.Drawing.Point(591, 80);
            this.lbl_AutoInsurance.Name = "lbl_AutoInsurance";
            this.lbl_AutoInsurance.Size = new System.Drawing.Size(97, 20);
            this.lbl_AutoInsurance.TabIndex = 13;
            this.lbl_AutoInsurance.Text = "Auto Insurance";
            this.lbl_AutoInsurance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_AutoInsurance.ThemeName = "Office2010Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 614);
            this.Controls.Add(this.lbl_AutoInsurance);
            this.Controls.Add(this.lbl_RentalInsurance);
            this.Controls.Add(this.lbl_Rent);
            this.Controls.Add(this.txt_RentalInsurance);
            this.Controls.Add(this.txt_AutoInsurance);
            this.Controls.Add(this.txt_rent);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.gradientPanelExt1);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudgetLog";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_BudgetLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetAutomateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelExt1)).EndInit();
            this.gradientPanelExt1.ResumeLayout(false);
            this.gradientPanelExt1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AutoInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RentalInsurance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl Grid_BudgetLog;
        private BudgetAutomateDataSet budgetAutomateDataSet;
        private System.Windows.Forms.BindingSource budgetLogBindingSource;
        private BudgetAutomateDataSetTableAdapters.BudgetLogTableAdapter budgetLogTableAdapter;
        private Syncfusion.WinForms.Controls.SfSkinManager sfSkinManager1;
        private Syncfusion.Windows.Forms.ButtonAdv butt_AutoInsurance;
        private Syncfusion.Windows.Forms.ButtonAdv butt_RentalInsurance;
        private Syncfusion.Windows.Forms.ButtonAdv butt_Rent;
        private Syncfusion.Windows.Forms.Tools.SplitButton splitButton_Vendor;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt gradientPanelExt1;
        private Syncfusion.Windows.Forms.ButtonAdv butt_Apply;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_Cost;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_Date;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lbl_AutoInsurance;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lbl_RentalInsurance;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lbl_Rent;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_RentalInsurance;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_AutoInsurance;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txt_rent;
    }
}

