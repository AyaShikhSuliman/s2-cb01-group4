namespace DesktopApplication.Scheduler.FeedingTimeTable
{
    partial class AssignedEmployee
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFeeding = new System.Windows.Forms.DateTimePicker();
            this.btnAssign = new System.Windows.Forms.Button();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DesktopApplication.Properties.Resources.ResourcePlanner_Report_animals_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1051, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(488, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose date";
            // 
            // dtpFeeding
            // 
            this.dtpFeeding.Location = new System.Drawing.Point(413, 275);
            this.dtpFeeding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFeeding.Name = "dtpFeeding";
            this.dtpFeeding.Size = new System.Drawing.Size(228, 27);
            this.dtpFeeding.TabIndex = 2;
            this.dtpFeeding.ValueChanged += new System.EventHandler(this.dtpFeeding_ValueChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(88, 365);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(86, 31);
            this.btnAssign.TabIndex = 3;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // cbEmployees
            // 
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Location = new System.Drawing.Point(413, 351);
            this.cbEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(228, 28);
            this.cbEmployees.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(469, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Available care takers";
            // 
            // AssignedEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.cbEmployees);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.dtpFeeding);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AssignedEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignedEmployee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssignedEmployee_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private DateTimePicker dtpFeeding;
        private Button btnAssign;
        private ComboBox cbEmployees;
        private Label label2;
    }
}