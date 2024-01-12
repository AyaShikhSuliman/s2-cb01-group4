namespace DesktopApplication.CommonForms.Animals
{
    partial class AddAnimalForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSicknesses = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.cbAllergies = new System.Windows.Forms.ComboBox();
            this.tbSicknesses = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.pcBackground = new System.Windows.Forms.PictureBox();
            this.tbFoodAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFoodType = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbConfirmation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(323, 231);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(331, 332);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(407, 329);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(351, 28);
            this.cbType.TabIndex = 4;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(407, 228);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(351, 27);
            this.tbName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Allergies:";
            // 
            // lblSicknesses
            // 
            this.lblSicknesses.AutoSize = true;
            this.lblSicknesses.BackColor = System.Drawing.Color.White;
            this.lblSicknesses.Location = new System.Drawing.Point(293, 429);
            this.lblSicknesses.Name = "lblSicknesses";
            this.lblSicknesses.Size = new System.Drawing.Size(80, 20);
            this.lblSicknesses.TabIndex = 7;
            this.lblSicknesses.Text = "Sicknesses:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(312, 264);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 20);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Gender:";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(313, 299);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(59, 20);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Weight:";
            // 
            // cbAllergies
            // 
            this.cbAllergies.FormattingEnabled = true;
            this.cbAllergies.Location = new System.Drawing.Point(407, 397);
            this.cbAllergies.Name = "cbAllergies";
            this.cbAllergies.Size = new System.Drawing.Size(351, 28);
            this.cbAllergies.TabIndex = 10;
            // 
            // tbSicknesses
            // 
            this.tbSicknesses.Location = new System.Drawing.Point(407, 431);
            this.tbSicknesses.Multiline = true;
            this.tbSicknesses.Name = "tbSicknesses";
            this.tbSicknesses.Size = new System.Drawing.Size(351, 32);
            this.tbSicknesses.TabIndex = 11;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(407, 261);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(351, 28);
            this.cbGender.TabIndex = 12;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(407, 296);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(351, 27);
            this.tbWeight.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Sienna;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::DesktopApplication.Properties.Resources.btn;
            this.btnAdd.Location = new System.Drawing.Point(107, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 28);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(306, 365);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(69, 20);
            this.lblLocation.TabIndex = 15;
            this.lblLocation.Text = "Location:";
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(407, 363);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(351, 28);
            this.cbLocation.TabIndex = 16;
            // 
            // pcBackground
            // 
            this.pcBackground.BackColor = System.Drawing.Color.White;
            this.pcBackground.Image = global::DesktopApplication.Properties.Resources.Admistration_Add_;
            this.pcBackground.Location = new System.Drawing.Point(-1, -3);
            this.pcBackground.Name = "pcBackground";
            this.pcBackground.Size = new System.Drawing.Size(1059, 643);
            this.pcBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBackground.TabIndex = 17;
            this.pcBackground.TabStop = false;
            // 
            // tbFoodAmount
            // 
            this.tbFoodAmount.Location = new System.Drawing.Point(407, 517);
            this.tbFoodAmount.Name = "tbFoodAmount";
            this.tbFoodAmount.Size = new System.Drawing.Size(351, 27);
            this.tbFoodAmount.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "FoodType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(293, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Food Amount:";
            // 
            // cbFoodType
            // 
            this.cbFoodType.FormattingEnabled = true;
            this.cbFoodType.Location = new System.Drawing.Point(407, 477);
            this.cbFoodType.Name = "cbFoodType";
            this.cbFoodType.Size = new System.Drawing.Size(351, 28);
            this.cbFoodType.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbConfirmation
            // 
            this.tbConfirmation.BackColor = System.Drawing.Color.Lime;
            this.tbConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmation.Enabled = false;
            this.tbConfirmation.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbConfirmation.ForeColor = System.Drawing.Color.Black;
            this.tbConfirmation.Location = new System.Drawing.Point(-1, 12);
            this.tbConfirmation.Multiline = true;
            this.tbConfirmation.Name = "tbConfirmation";
            this.tbConfirmation.Size = new System.Drawing.Size(1051, 41);
            this.tbConfirmation.TabIndex = 23;
            this.tbConfirmation.Text = "Animal Added";
            this.tbConfirmation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.tbConfirmation);
            this.Controls.Add(this.cbFoodType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFoodAmount);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnAdd);
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
            this.Controls.Add(this.pcBackground);
            this.Name = "AddAnimalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add an Animal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAnimalForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblName;
        private Label lblType;
        private ComboBox cbType;
        private TextBox tbName;
        private Label label1;
        private Label lblSicknesses;
        private Label lblGender;
        private Label lblWeight;
        private ComboBox cbAllergies;
        private TextBox tbSicknesses;
        private ComboBox cbGender;
        private TextBox tbWeight;
        private Button btnAdd;
        private Label lblLocation;
        private ComboBox cbLocation;
        private PictureBox pcBackground;
        private TextBox tbFoodAmount;
        private Label label2;
        private Label label3;
        private ComboBox cbFoodType;
		private System.Windows.Forms.Timer timer1;
		private TextBox tbConfirmation;
	}
}