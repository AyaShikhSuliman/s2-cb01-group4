namespace DesktopApplication.Scheduler.Animals.FeedingTimetable
{
    partial class AddFeedingTimeForm
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
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.lblFoodType = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAnimalType = new System.Windows.Forms.Label();
            this.cbAnimalType = new System.Windows.Forms.ComboBox();
            this.cbFeedingTime = new System.Windows.Forms.ComboBox();
            this.cbFoodtType = new System.Windows.Forms.ComboBox();
            this.tbFoodAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAmountOfAnimal = new System.Windows.Forms.TextBox();
            this.grams = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNeededTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tbConfirmation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackground
            // 
            this.pbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackground.Image = global::DesktopApplication.Properties.Resources.Admistration_Add_;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1051, 637);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 1;
            this.pbBackground.TabStop = false;
            // 
            // lblFoodType
            // 
            this.lblFoodType.AutoSize = true;
            this.lblFoodType.BackColor = System.Drawing.Color.White;
            this.lblFoodType.Location = new System.Drawing.Point(342, 360);
            this.lblFoodType.Name = "lblFoodType";
            this.lblFoodType.Size = new System.Drawing.Size(79, 20);
            this.lblFoodType.TabIndex = 13;
            this.lblFoodType.Text = "Food type:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(322, 275);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 20);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Feeding time:";
            // 
            // lblAnimalType
            // 
            this.lblAnimalType.AutoSize = true;
            this.lblAnimalType.BackColor = System.Drawing.Color.White;
            this.lblAnimalType.Location = new System.Drawing.Point(329, 315);
            this.lblAnimalType.Name = "lblAnimalType";
            this.lblAnimalType.Size = new System.Drawing.Size(92, 20);
            this.lblAnimalType.TabIndex = 23;
            this.lblAnimalType.Text = "Animal type:";
            // 
            // cbAnimalType
            // 
            this.cbAnimalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnimalType.FormattingEnabled = true;
            this.cbAnimalType.Location = new System.Drawing.Point(428, 312);
            this.cbAnimalType.Name = "cbAnimalType";
            this.cbAnimalType.Size = new System.Drawing.Size(377, 28);
            this.cbAnimalType.TabIndex = 15;
            this.cbAnimalType.SelectedIndexChanged += new System.EventHandler(this.cbAnimalType_SelectedIndexChanged);
            // 
            // cbFeedingTime
            // 
            this.cbFeedingTime.FormattingEnabled = true;
            this.cbFeedingTime.Items.AddRange(new object[] {
            "08.00",
            "09.00",
            "10.00",
            "11.00",
            "12.00",
            "13.00",
            "14.00",
            "15.00",
            "16.00",
            "17.00",
            "18.00",
            "19.00",
            "20.00",
            "21.00",
            "22.00",
            "23.00",
            "00.00"});
            this.cbFeedingTime.Location = new System.Drawing.Point(428, 272);
            this.cbFeedingTime.Name = "cbFeedingTime";
            this.cbFeedingTime.Size = new System.Drawing.Size(377, 28);
            this.cbFeedingTime.TabIndex = 25;
            // 
            // cbFoodtType
            // 
            this.cbFoodtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodtType.FormattingEnabled = true;
            this.cbFoodtType.Location = new System.Drawing.Point(427, 357);
            this.cbFoodtType.Name = "cbFoodtType";
            this.cbFoodtType.Size = new System.Drawing.Size(378, 28);
            this.cbFoodtType.TabIndex = 28;
            // 
            // tbFoodAmount
            // 
            this.tbFoodAmount.Location = new System.Drawing.Point(427, 395);
            this.tbFoodAmount.Name = "tbFoodAmount";
            this.tbFoodAmount.Size = new System.Drawing.Size(322, 27);
            this.tbFoodAmount.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Total needed food:";
            // 
            // tbAmountOfAnimal
            // 
            this.tbAmountOfAnimal.Location = new System.Drawing.Point(428, 439);
            this.tbAmountOfAnimal.Name = "tbAmountOfAnimal";
            this.tbAmountOfAnimal.ReadOnly = true;
            this.tbAmountOfAnimal.Size = new System.Drawing.Size(377, 27);
            this.tbAmountOfAnimal.TabIndex = 34;
            // 
            // grams
            // 
            this.grams.AutoSize = true;
            this.grams.BackColor = System.Drawing.Color.White;
            this.grams.Location = new System.Drawing.Point(755, 398);
            this.grams.Name = "grams";
            this.grams.Size = new System.Drawing.Size(50, 20);
            this.grams.TabIndex = 35;
            this.grams.Text = "grams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(289, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Amount of animal:";
            // 
            // tbNeededTime
            // 
            this.tbNeededTime.Location = new System.Drawing.Point(427, 483);
            this.tbNeededTime.Name = "tbNeededTime";
            this.tbNeededTime.Size = new System.Drawing.Size(311, 27);
            this.tbNeededTime.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(288, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Total needed time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(744, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "minutes";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::DesktopApplication.Properties.Resources.btn;
            this.button1.Location = new System.Drawing.Point(105, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 28);
            this.button1.TabIndex = 41;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tbConfirmation.TabIndex = 42;
            this.tbConfirmation.Text = "Feeding Time Added";
            this.tbConfirmation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddFeedingTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.tbConfirmation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNeededTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grams);
            this.Controls.Add(this.tbAmountOfAnimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFoodAmount);
            this.Controls.Add(this.cbFoodtType);
            this.Controls.Add(this.cbFeedingTime);
            this.Controls.Add(this.lblAnimalType);
            this.Controls.Add(this.cbAnimalType);
            this.Controls.Add(this.lblFoodType);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pbBackground);
            this.Name = "AddFeedingTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Feeding Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddFeedingTimeForm_FormClosing);
            this.Load += new System.EventHandler(this.AddFeedingTimeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbBackground;
        private Label lblFoodType;
        private Label lblTime;
        private Label lblAnimalType;
        private ComboBox cbAnimalType;
        private ComboBox cbFeedingTime;
        private ComboBox cbFoodtType;
        private TextBox tbFoodAmount;
        private Label label1;
        private TextBox tbAmountOfAnimal;
        private Label grams;
        private Label label2;
        private TextBox tbNeededTime;
        private Label label3;
        private Label label4;
		private System.Windows.Forms.Timer timer1;
        private Button button1;
        private TextBox tbConfirmation;
    }
}