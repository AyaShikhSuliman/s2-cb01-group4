namespace DesktopApplication.Scheduler.Employees
{
    partial class EmployeeScedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeScedule));
            this.lvEmployeeSchdule = new System.Windows.Forms.ListView();
            this.pcBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lvEmployeeSchdule
            // 
            this.lvEmployeeSchdule.FullRowSelect = true;
            this.lvEmployeeSchdule.Location = new System.Drawing.Point(249, 174);
            this.lvEmployeeSchdule.Name = "lvEmployeeSchdule";
            this.lvEmployeeSchdule.Size = new System.Drawing.Size(593, 406);
            this.lvEmployeeSchdule.TabIndex = 2;
            this.lvEmployeeSchdule.UseCompatibleStateImageBehavior = false;
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
            this.pcBackground.TabIndex = 3;
            this.pcBackground.TabStop = false;
            // 
            // EmployeeScedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.lvEmployeeSchdule);
            this.Controls.Add(this.pcBackground);
            this.Name = "EmployeeScedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Main Schedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeScedule_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvEmployeeSchdule;
        private PictureBox pcBackground;
    }
}