namespace DesktopApplication.Scheduler.Employees
{
    partial class ShiftCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftCreatorForm));
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.ChooseDate = new System.Windows.Forms.DateTimePicker();
            this.cbShiftTimes = new System.Windows.Forms.ComboBox();
            this.pcBackground = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbConfirmation = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExtraInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 20;
            this.lbInfo.Location = new System.Drawing.Point(261, 189);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(568, 244);
            this.lbInfo.TabIndex = 0;
            // 
            // ChooseDate
            // 
            this.ChooseDate.Location = new System.Drawing.Point(261, 458);
            this.ChooseDate.Name = "ChooseDate";
            this.ChooseDate.Size = new System.Drawing.Size(568, 27);
            this.ChooseDate.TabIndex = 1;
            // 
            // cbShiftTimes
            // 
            this.cbShiftTimes.FormattingEnabled = true;
            this.cbShiftTimes.Location = new System.Drawing.Point(261, 511);
            this.cbShiftTimes.Name = "cbShiftTimes";
            this.cbShiftTimes.Size = new System.Drawing.Size(571, 28);
            this.cbShiftTimes.TabIndex = 2;
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
            this.pcBackground.TabIndex = 4;
            this.pcBackground.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Sienna;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::DesktopApplication.Properties.Resources.btn;
            this.btnAdd.Location = new System.Drawing.Point(108, 382);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 28);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbConfirmation
            // 
            this.tbConfirmation.BackColor = System.Drawing.Color.Lime;
            this.tbConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmation.Enabled = false;
            this.tbConfirmation.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbConfirmation.ForeColor = System.Drawing.Color.Black;
            this.tbConfirmation.Location = new System.Drawing.Point(0, 12);
            this.tbConfirmation.Multiline = true;
            this.tbConfirmation.Name = "tbConfirmation";
            this.tbConfirmation.Size = new System.Drawing.Size(1051, 41);
            this.tbConfirmation.TabIndex = 25;
            this.tbConfirmation.Text = "Shift Added";
            this.tbConfirmation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExtraInfo
            // 
            this.btnExtraInfo.BackColor = System.Drawing.Color.Sienna;
            this.btnExtraInfo.FlatAppearance.BorderSize = 0;
            this.btnExtraInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtraInfo.ForeColor = System.Drawing.Color.White;
            this.btnExtraInfo.Image = global::DesktopApplication.Properties.Resources.btn;
            this.btnExtraInfo.Location = new System.Drawing.Point(470, 111);
            this.btnExtraInfo.Name = "btnExtraInfo";
            this.btnExtraInfo.Size = new System.Drawing.Size(147, 28);
            this.btnExtraInfo.TabIndex = 26;
            this.btnExtraInfo.Text = "Additional Info";
            this.btnExtraInfo.UseVisualStyleBackColor = false;
            this.btnExtraInfo.Click += new System.EventHandler(this.btnExtraInfo_Click);
            // 
            // ShiftCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.btnExtraInfo);
            this.Controls.Add(this.tbConfirmation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbShiftTimes);
            this.Controls.Add(this.ChooseDate);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.pcBackground);
            this.Name = "ShiftCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Shift";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShiftCreatorForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbInfo;
        private DateTimePicker ChooseDate;
        private ComboBox cbShiftTimes;
        private PictureBox pcBackground;
        private Button btnAdd;
        private TextBox tbConfirmation;
        private System.Windows.Forms.Timer timer1;
        private Button btnExtraInfo;
    }
}