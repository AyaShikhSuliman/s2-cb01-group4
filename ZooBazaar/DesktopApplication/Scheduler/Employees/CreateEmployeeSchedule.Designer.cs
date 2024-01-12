namespace DesktopApplication.Scheduler.Employees
{
    partial class Create_Employee_Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Employee_Schedule));
            this.dateTimePickerShifts = new System.Windows.Forms.DateTimePicker();
            this.cbShiftType = new System.Windows.Forms.ComboBox();
            this.lbEmployeesForShift = new System.Windows.Forms.ListBox();
            this.lbShifts = new System.Windows.Forms.ListBox();
            this.btnCreateShift = new System.Windows.Forms.Button();
            this.btnEditShift = new System.Windows.Forms.Button();
            this.btnDeleteShift = new System.Windows.Forms.Button();
            this.pcBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerShifts
            // 
            this.dateTimePickerShifts.Location = new System.Drawing.Point(256, 187);
            this.dateTimePickerShifts.Name = "dateTimePickerShifts";
            this.dateTimePickerShifts.Size = new System.Drawing.Size(284, 27);
            this.dateTimePickerShifts.TabIndex = 0;
            // 
            // cbShiftType
            // 
            this.cbShiftType.FormattingEnabled = true;
            this.cbShiftType.Location = new System.Drawing.Point(604, 186);
            this.cbShiftType.Name = "cbShiftType";
            this.cbShiftType.Size = new System.Drawing.Size(221, 28);
            this.cbShiftType.TabIndex = 1;
            // 
            // lbEmployeesForShift
            // 
            this.lbEmployeesForShift.FormattingEnabled = true;
            this.lbEmployeesForShift.ItemHeight = 20;
            this.lbEmployeesForShift.Location = new System.Drawing.Point(256, 230);
            this.lbEmployeesForShift.Name = "lbEmployeesForShift";
            this.lbEmployeesForShift.Size = new System.Drawing.Size(569, 124);
            this.lbEmployeesForShift.TabIndex = 2;
            this.lbEmployeesForShift.SelectedIndexChanged += new System.EventHandler(this.lbEmployeesForShift_SelectedIndexChanged);
            // 
            // lbShifts
            // 
            this.lbShifts.FormattingEnabled = true;
            this.lbShifts.ItemHeight = 20;
            this.lbShifts.Location = new System.Drawing.Point(256, 360);
            this.lbShifts.Name = "lbShifts";
            this.lbShifts.Size = new System.Drawing.Size(569, 164);
            this.lbShifts.TabIndex = 3;
            // 
            // btnCreateShift
            // 
            this.btnCreateShift.Location = new System.Drawing.Point(256, 539);
            this.btnCreateShift.Name = "btnCreateShift";
            this.btnCreateShift.Size = new System.Drawing.Size(164, 29);
            this.btnCreateShift.TabIndex = 4;
            this.btnCreateShift.Text = "Create Shift";
            this.btnCreateShift.UseVisualStyleBackColor = true;
            this.btnCreateShift.Click += new System.EventHandler(this.btnCreateShift_Click);
            // 
            // btnEditShift
            // 
            this.btnEditShift.Location = new System.Drawing.Point(644, 539);
            this.btnEditShift.Name = "btnEditShift";
            this.btnEditShift.Size = new System.Drawing.Size(164, 29);
            this.btnEditShift.TabIndex = 5;
            this.btnEditShift.Text = "Edit Shift";
            this.btnEditShift.UseVisualStyleBackColor = true;
            this.btnEditShift.Click += new System.EventHandler(this.btnEditShift_Click);
            // 
            // btnDeleteShift
            // 
            this.btnDeleteShift.Location = new System.Drawing.Point(454, 539);
            this.btnDeleteShift.Name = "btnDeleteShift";
            this.btnDeleteShift.Size = new System.Drawing.Size(164, 29);
            this.btnDeleteShift.TabIndex = 6;
            this.btnDeleteShift.Text = "Delete Shift";
            this.btnDeleteShift.UseVisualStyleBackColor = true;
            this.btnDeleteShift.Click += new System.EventHandler(this.btnDeleteShift_Click);
            // 
            // pcBackground
            // 
            this.pcBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcBackground.Image = ((System.Drawing.Image)(resources.GetObject("pcBackground.Image")));
            this.pcBackground.Location = new System.Drawing.Point(0, 0);
            this.pcBackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcBackground.Name = "pcBackground";
            this.pcBackground.Size = new System.Drawing.Size(1051, 637);
            this.pcBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBackground.TabIndex = 7;
            this.pcBackground.TabStop = false;
            // 
            // Create_Employee_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.btnDeleteShift);
            this.Controls.Add(this.btnEditShift);
            this.Controls.Add(this.btnCreateShift);
            this.Controls.Add(this.lbShifts);
            this.Controls.Add(this.lbEmployeesForShift);
            this.Controls.Add(this.cbShiftType);
            this.Controls.Add(this.dateTimePickerShifts);
            this.Controls.Add(this.pcBackground);
            this.Name = "Create_Employee_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Employee Schedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Create_Employee_Schedule_FormClosing);
            this.Load += new System.EventHandler(this.Create_Employee_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DateTimePicker dateTimePickerShifts;
        private ComboBox cbShiftType;
        private ListBox lbEmployeesForShift;
        private ListBox lbShifts;
        private Button btnCreateShift;
        private Button btnEditShift;
        private Button btnDeleteShift;
        private PictureBox pcBackground;
    }
}