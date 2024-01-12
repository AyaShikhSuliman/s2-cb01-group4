namespace DesktopApplication.Scheduler.Animals
{
    partial class FeedingTimetableForm
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
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.lvFeedingTimetable = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAssignEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackground
            // 
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Image = global::DesktopApplication.Properties.Resources.ResourcePlanner_General_Employee_;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(920, 478);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // lvFeedingTimetable
            // 
            this.lvFeedingTimetable.FullRowSelect = true;
            this.lvFeedingTimetable.Location = new System.Drawing.Point(198, 124);
            this.lvFeedingTimetable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvFeedingTimetable.Name = "lvFeedingTimetable";
            this.lvFeedingTimetable.Size = new System.Drawing.Size(495, 298);
            this.lvFeedingTimetable.TabIndex = 1;
            this.lvFeedingTimetable.UseCompatibleStateImageBehavior = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Sienna;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::DesktopApplication.Properties.Resources.btn;
            this.btnDelete.Location = new System.Drawing.Point(74, 300);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 21);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Sienna;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::DesktopApplication.Properties.Resources.btn;
            this.btnAdd.Location = new System.Drawing.Point(74, 263);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 21);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAssignEmployee
            // 
            this.btnAssignEmployee.BackColor = System.Drawing.Color.Sienna;
            this.btnAssignEmployee.FlatAppearance.BorderSize = 0;
            this.btnAssignEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAssignEmployee.Image = global::DesktopApplication.Properties.Resources.btn;
            this.btnAssignEmployee.Location = new System.Drawing.Point(74, 325);
            this.btnAssignEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAssignEmployee.Name = "btnAssignEmployee";
            this.btnAssignEmployee.Size = new System.Drawing.Size(64, 40);
            this.btnAssignEmployee.TabIndex = 42;
            this.btnAssignEmployee.Text = "Assign employee";
            this.btnAssignEmployee.UseVisualStyleBackColor = false;
            this.btnAssignEmployee.Click += new System.EventHandler(this.btnAssignEmployee_Click);
            // 
            // FeedingTimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 478);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAssignEmployee);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvFeedingTimetable);
            this.Controls.Add(this.pbBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "FeedingTimetableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Feeding Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateFeedingTimetableForm_FormClosing);
            this.Load += new System.EventHandler(this.FeedingTimetableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbBackground;
        private ListView lvFeedingTimetable;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnAssignEmployee;
    }
}