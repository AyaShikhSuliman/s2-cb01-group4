namespace DesktopApplication.Adminstration.Clients.ContactForms
{
	partial class ContactFormsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactFormsForm));
            this.pcBackground = new System.Windows.Forms.PictureBox();
            this.btnAnswer = new System.Windows.Forms.Label();
            this.lvContactForms = new System.Windows.Forms.ListView();
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
            this.pcBackground.TabIndex = 1;
            this.pcBackground.TabStop = false;
            // 
            // btnAnswer
            // 
            this.btnAnswer.AutoSize = true;
            this.btnAnswer.BackColor = System.Drawing.Color.Transparent;
            this.btnAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer.ForeColor = System.Drawing.Color.White;
            this.btnAnswer.Image = global::DesktopApplication.Properties.Resources.btn;
            this.btnAnswer.Location = new System.Drawing.Point(99, 384);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.btnAnswer.Size = new System.Drawing.Size(91, 20);
            this.btnAnswer.TabIndex = 13;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lvContactForms
            // 
            this.lvContactForms.FullRowSelect = true;
            this.lvContactForms.HoverSelection = true;
            this.lvContactForms.Location = new System.Drawing.Point(261, 174);
            this.lvContactForms.Name = "lvContactForms";
            this.lvContactForms.Size = new System.Drawing.Size(577, 408);
            this.lvContactForms.TabIndex = 14;
            this.lvContactForms.UseCompatibleStateImageBehavior = false;
            this.lvContactForms.SelectedIndexChanged += new System.EventHandler(this.lvContactForms_SelectedIndexChanged);
            // 
            // ContactFormsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.lvContactForms);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.pcBackground);
            this.Name = "ContactFormsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Forms General";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactFormsForm_FormClosing);
            this.Load += new System.EventHandler(this.ContactFormsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private PictureBox pcBackground;
		private Label btnAnswer;
		private ListView lvContactForms;
	}
}