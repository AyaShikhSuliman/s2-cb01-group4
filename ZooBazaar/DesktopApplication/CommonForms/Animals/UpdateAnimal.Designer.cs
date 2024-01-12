namespace DesktopApplication.CommonForms.Animals
{
    partial class UpdateAnimal
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pcBackground = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbSicknesses = new System.Windows.Forms.TextBox();
            this.cbAllergies = new System.Windows.Forms.ComboBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSicknesses = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbConfirmation = new System.Windows.Forms.TextBox();
            this.tbConfirmation1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(392, 223);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(351, 27);
            this.tbId.TabIndex = 21;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(331, 227);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "Id:";
            // 
            // pcBackground
            // 
            this.pcBackground.BackColor = System.Drawing.Color.White;
            this.pcBackground.Image = global::DesktopApplication.Properties.Resources.Admistration_Add_;
            this.pcBackground.Location = new System.Drawing.Point(1, 1);
            this.pcBackground.Name = "pcBackground";
            this.pcBackground.Size = new System.Drawing.Size(1059, 643);
            this.pcBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBackground.TabIndex = 35;
            this.pcBackground.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(109, 392);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUpdate.Size = new System.Drawing.Size(55, 20);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(392, 391);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(351, 28);
            this.cbLocation.TabIndex = 50;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(291, 395);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(69, 20);
            this.lblLocation.TabIndex = 49;
            this.lblLocation.Text = "Location:";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(392, 324);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(351, 27);
            this.tbWeight.TabIndex = 48;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(392, 289);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(351, 28);
            this.cbGender.TabIndex = 47;
            // 
            // tbSicknesses
            // 
            this.tbSicknesses.Location = new System.Drawing.Point(392, 459);
            this.tbSicknesses.Multiline = true;
            this.tbSicknesses.Name = "tbSicknesses";
            this.tbSicknesses.Size = new System.Drawing.Size(351, 81);
            this.tbSicknesses.TabIndex = 46;
            // 
            // cbAllergies
            // 
            this.cbAllergies.FormattingEnabled = true;
            this.cbAllergies.Location = new System.Drawing.Point(392, 425);
            this.cbAllergies.Name = "cbAllergies";
            this.cbAllergies.Size = new System.Drawing.Size(351, 28);
            this.cbAllergies.TabIndex = 45;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(298, 327);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(59, 20);
            this.lblWeight.TabIndex = 44;
            this.lblWeight.Text = "Weight:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(297, 292);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 20);
            this.lblGender.TabIndex = 43;
            this.lblGender.Text = "Gender:";
            // 
            // lblSicknesses
            // 
            this.lblSicknesses.AutoSize = true;
            this.lblSicknesses.BackColor = System.Drawing.Color.White;
            this.lblSicknesses.Location = new System.Drawing.Point(277, 459);
            this.lblSicknesses.Name = "lblSicknesses";
            this.lblSicknesses.Size = new System.Drawing.Size(80, 20);
            this.lblSicknesses.TabIndex = 42;
            this.lblSicknesses.Text = "Sicknesses:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Allergies:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(392, 256);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(351, 27);
            this.tbName.TabIndex = 40;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(392, 357);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(351, 28);
            this.cbType.TabIndex = 39;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(317, 360);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 38;
            this.lblType.Text = "Type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(309, 259);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Name:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbConfirmation
            // 
            this.tbConfirmation.BackColor = System.Drawing.Color.DarkGreen;
            this.tbConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmation.Enabled = false;
            this.tbConfirmation.ForeColor = System.Drawing.Color.YellowGreen;
            this.tbConfirmation.Location = new System.Drawing.Point(5, 300);
            this.tbConfirmation.Name = "tbConfirmation";
            this.tbConfirmation.Size = new System.Drawing.Size(0, 20);
            this.tbConfirmation.TabIndex = 51;
            // 
            // tbConfirmation1
            // 
            this.tbConfirmation1.BackColor = System.Drawing.Color.Lime;
            this.tbConfirmation1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmation1.Enabled = false;
            this.tbConfirmation1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbConfirmation1.ForeColor = System.Drawing.Color.Black;
            this.tbConfirmation1.Location = new System.Drawing.Point(1, 12);
            this.tbConfirmation1.Multiline = true;
            this.tbConfirmation1.Name = "tbConfirmation1";
            this.tbConfirmation1.Size = new System.Drawing.Size(1051, 41);
            this.tbConfirmation1.TabIndex = 52;
            this.tbConfirmation1.Text = "Animal Edited";
            this.tbConfirmation1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 620);
            this.Controls.Add(this.tbConfirmation1);
            this.Controls.Add(this.tbConfirmation);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.tbSicknesses);
            this.Controls.Add(this.cbAllergies);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblSicknesses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pcBackground);
            this.Name = "UpdateAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit an Animal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateAnimal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbId;
        private Label lblId;
        private PictureBox pcBackground;
        private Label btnUpdate;
        private ComboBox cbLocation;
        private Label lblLocation;
        private TextBox tbWeight;
        private ComboBox cbGender;
        private TextBox tbSicknesses;
        private ComboBox cbAllergies;
        private Label lblWeight;
        private Label lblGender;
        private Label lblSicknesses;
        private Label label1;
        private TextBox tbName;
        private ComboBox cbType;
        private Label lblType;
        private Label lblName;
		private System.Windows.Forms.Timer timer1;
		private TextBox tbConfirmation;
		private TextBox tbConfirmation1;
	}
}