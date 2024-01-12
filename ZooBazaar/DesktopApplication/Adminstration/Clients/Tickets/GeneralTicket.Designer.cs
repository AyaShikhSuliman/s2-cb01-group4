namespace DesktopApplication.Adminstration.Clients.Tickets
{
    partial class GeneralTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralTicket));
            this.pcBackground = new System.Windows.Forms.PictureBox();
            this.lvContactForms = new System.Windows.Forms.ListView();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).BeginInit();
            this.SuspendLayout();
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
            this.pcBackground.TabIndex = 2;
            this.pcBackground.TabStop = false;
            // 
            // lvContactForms
            // 
            this.lvContactForms.FullRowSelect = true;
            this.lvContactForms.HoverSelection = true;
            this.lvContactForms.Location = new System.Drawing.Point(262, 172);
            this.lvContactForms.Name = "lvContactForms";
            this.lvContactForms.Size = new System.Drawing.Size(577, 408);
            this.lvContactForms.TabIndex = 15;
            this.lvContactForms.UseCompatibleStateImageBehavior = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(271, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(326, 118);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(479, 27);
            this.tbEmail.TabIndex = 17;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // GeneralTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lvContactForms);
            this.Controls.Add(this.pcBackground);
            this.Name = "GeneralTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralTicket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralTicket_FormClosing);
            this.Load += new System.EventHandler(this.GeneralTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcBackground;
        private ListView lvContactForms;
        private Label lblEmail;
        private TextBox tbEmail;
    }
}