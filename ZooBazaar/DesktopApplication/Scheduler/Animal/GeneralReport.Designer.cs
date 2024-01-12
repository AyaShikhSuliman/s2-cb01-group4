namespace DesktopApplication.Scheduler.Animal
{
    partial class GeneralReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralReport));
            this.lvReports = new System.Windows.Forms.ListView();
            this.lblId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.pcBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lvReports
            // 
            this.lvReports.FullRowSelect = true;
            this.lvReports.HoverSelection = true;
            this.lvReports.Location = new System.Drawing.Point(241, 167);
            this.lvReports.Name = "lvReports";
            this.lvReports.Size = new System.Drawing.Size(592, 419);
            this.lvReports.TabIndex = 11;
            this.lvReports.UseCompatibleStateImageBehavior = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.SkyBlue;
            this.lblId.Location = new System.Drawing.Point(287, 100);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id:";
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.SaddleBrown;
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.ForeColor = System.Drawing.Color.White;
            this.tbId.Location = new System.Drawing.Point(318, 99);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(448, 24);
            this.tbId.TabIndex = 12;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
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
            this.pcBackground.TabIndex = 1;
            this.pcBackground.TabStop = false;
            // 
            // GeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lvReports);
            this.Controls.Add(this.pcBackground);
            this.Name = "GeneralReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Report";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralReport_FormClosing);
            this.Load += new System.EventHandler(this.GeneralReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListView lvReports;
        private Label lblId;
        private TextBox tbId;
        private PictureBox pcBackground;
    }
}