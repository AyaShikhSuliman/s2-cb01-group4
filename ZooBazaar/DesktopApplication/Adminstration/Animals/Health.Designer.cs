namespace DesktopApplication.Adminstration.Animals
{
    partial class HealthForm
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
            this.lblAnimalsWithSicknesses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSickness = new System.Windows.Forms.ListBox();
            this.lbAllergies = new System.Windows.Forms.ListBox();
            this.tbSicknesses = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSicknesses = new System.Windows.Forms.Label();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.tbAllergies = new System.Windows.Forms.TextBox();
            this.btnSearchSickness = new System.Windows.Forms.Button();
            this.tbSearchAllergy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DesktopApplication.Properties.Resources.Adminstration_Attendance_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1051, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAnimalsWithSicknesses
            // 
            this.lblAnimalsWithSicknesses.AutoSize = true;
            this.lblAnimalsWithSicknesses.BackColor = System.Drawing.Color.White;
            this.lblAnimalsWithSicknesses.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnimalsWithSicknesses.Location = new System.Drawing.Point(301, 291);
            this.lblAnimalsWithSicknesses.Name = "lblAnimalsWithSicknesses";
            this.lblAnimalsWithSicknesses.Size = new System.Drawing.Size(185, 31);
            this.lblAnimalsWithSicknesses.TabIndex = 1;
            this.lblAnimalsWithSicknesses.Text = "With Sicknesses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(610, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "With Allergies";
            // 
            // lbSickness
            // 
            this.lbSickness.FormattingEnabled = true;
            this.lbSickness.ItemHeight = 20;
            this.lbSickness.Location = new System.Drawing.Point(295, 325);
            this.lbSickness.Name = "lbSickness";
            this.lbSickness.Size = new System.Drawing.Size(197, 224);
            this.lbSickness.TabIndex = 3;
            this.lbSickness.SelectedIndexChanged += new System.EventHandler(this.lbSickness_SelectedIndexChanged);
            // 
            // lbAllergies
            // 
            this.lbAllergies.FormattingEnabled = true;
            this.lbAllergies.ItemHeight = 20;
            this.lbAllergies.Location = new System.Drawing.Point(586, 325);
            this.lbAllergies.Name = "lbAllergies";
            this.lbAllergies.Size = new System.Drawing.Size(208, 224);
            this.lbAllergies.TabIndex = 4;
            this.lbAllergies.SelectedIndexChanged += new System.EventHandler(this.lbAllergies_SelectedIndexChanged);
            // 
            // tbSicknesses
            // 
            this.tbSicknesses.Location = new System.Drawing.Point(387, 211);
            this.tbSicknesses.Name = "tbSicknesses";
            this.tbSicknesses.Size = new System.Drawing.Size(279, 27);
            this.tbSicknesses.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(301, 185);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 20);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search:";
            // 
            // lblSicknesses
            // 
            this.lblSicknesses.AutoSize = true;
            this.lblSicknesses.BackColor = System.Drawing.Color.White;
            this.lblSicknesses.Location = new System.Drawing.Point(301, 214);
            this.lblSicknesses.Name = "lblSicknesses";
            this.lblSicknesses.Size = new System.Drawing.Size(80, 20);
            this.lblSicknesses.TabIndex = 7;
            this.lblSicknesses.Text = "Sicknesses:";
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.BackColor = System.Drawing.Color.White;
            this.lblAllergies.Location = new System.Drawing.Point(301, 247);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(70, 20);
            this.lblAllergies.TabIndex = 9;
            this.lblAllergies.Text = "Allergies:";
            // 
            // tbAllergies
            // 
            this.tbAllergies.Location = new System.Drawing.Point(387, 244);
            this.tbAllergies.Name = "tbAllergies";
            this.tbAllergies.Size = new System.Drawing.Size(279, 27);
            this.tbAllergies.TabIndex = 8;
            // 
            // btnSearchSickness
            // 
            this.btnSearchSickness.Location = new System.Drawing.Point(672, 210);
            this.btnSearchSickness.Name = "btnSearchSickness";
            this.btnSearchSickness.Size = new System.Drawing.Size(122, 29);
            this.btnSearchSickness.TabIndex = 10;
            this.btnSearchSickness.Text = "Search";
            this.btnSearchSickness.UseVisualStyleBackColor = true;
            this.btnSearchSickness.Click += new System.EventHandler(this.tbSearchSickness_Click);
            // 
            // tbSearchAllergy
            // 
            this.tbSearchAllergy.Location = new System.Drawing.Point(672, 243);
            this.tbSearchAllergy.Name = "tbSearchAllergy";
            this.tbSearchAllergy.Size = new System.Drawing.Size(122, 29);
            this.tbSearchAllergy.TabIndex = 11;
            this.tbSearchAllergy.Text = "Search";
            this.tbSearchAllergy.UseVisualStyleBackColor = true;
            this.tbSearchAllergy.Click += new System.EventHandler(this.tbSearchAllergy_Click);
            // 
            // HealthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.tbSearchAllergy);
            this.Controls.Add(this.btnSearchSickness);
            this.Controls.Add(this.lblAllergies);
            this.Controls.Add(this.tbAllergies);
            this.Controls.Add(this.lblSicknesses);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSicknesses);
            this.Controls.Add(this.lbAllergies);
            this.Controls.Add(this.lbSickness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAnimalsWithSicknesses);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HealthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Situation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HealthForm_FormClosing);
            this.Load += new System.EventHandler(this.HealthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblAnimalsWithSicknesses;
        private Label label2;
        private ListBox lbSickness;
        private ListBox lbAllergies;
        private TextBox tbSicknesses;
        private Label lblSearch;
        private Label lblSicknesses;
        private Label lblAllergies;
        private TextBox tbAllergies;
        private Button btnSearchSickness;
        private Button tbSearchAllergy;
    }
}