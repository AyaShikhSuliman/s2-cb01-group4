namespace DesktopApplication.Adminstration.Animals
{
    partial class AnimalGeneralForm
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
            this.pcBackground = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lvAnimals = new System.Windows.Forms.ListView();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBackground
            // 
            this.pcBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcBackground.Image = global::DesktopApplication.Properties.Resources.animal_general;
            this.pcBackground.Location = new System.Drawing.Point(0, 0);
            this.pcBackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcBackground.Name = "pcBackground";
            this.pcBackground.Size = new System.Drawing.Size(1051, 637);
            this.pcBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBackground.TabIndex = 0;
            this.pcBackground.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Sienna;
            this.btnAdd.BackgroundImage = global::DesktopApplication.Properties.Resources.btn;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(94, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 31);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Sienna;
            this.btnRemove.BackgroundImage = global::DesktopApplication.Properties.Resources.btn;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(94, 405);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(72, 28);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbId
            // 
            this.tbId.BackColor = System.Drawing.Color.SaddleBrown;
            this.tbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbId.ForeColor = System.Drawing.Color.White;
            this.tbId.Location = new System.Drawing.Point(320, 100);
            this.tbId.Multiline = true;
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(107, 24);
            this.tbId.TabIndex = 4;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.SaddleBrown;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(660, 100);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(105, 24);
            this.tbName.TabIndex = 6;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.SkyBlue;
            this.lblId.Location = new System.Drawing.Point(289, 101);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.SkyBlue;
            this.lblType.Location = new System.Drawing.Point(447, 100);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.SkyBlue;
            this.lblName.Location = new System.Drawing.Point(604, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // lvAnimals
            // 
            this.lvAnimals.FullRowSelect = true;
            this.lvAnimals.HoverSelection = true;
            this.lvAnimals.Location = new System.Drawing.Point(254, 159);
            this.lvAnimals.Name = "lvAnimals";
            this.lvAnimals.Size = new System.Drawing.Size(577, 424);
            this.lvAnimals.TabIndex = 10;
            this.lvAnimals.UseCompatibleStateImageBehavior = false;
            this.lvAnimals.SelectedIndexChanged += new System.EventHandler(this.lvAnimals_SelectedIndexChanged_1);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.SaddleBrown;
            this.cbType.ForeColor = System.Drawing.Color.White;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(496, 98);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(106, 28);
            this.cbType.TabIndex = 11;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            this.cbType.TextChanged += new System.EventHandler(this.cbType_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::DesktopApplication.Properties.Resources.btn;
            this.btnEdit.Location = new System.Drawing.Point(94, 456);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.btnEdit.Size = new System.Drawing.Size(69, 20);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // AnimalGeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.lvAnimals);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pcBackground);
            this.Name = "AnimalGeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal General";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnimalGeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.AnimalGeneralForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcBackground;
        private Button btnAdd;
        private Button btnRemove;
        private TextBox tbId;
        private TextBox tbName;
        private Label lblId;
        private Label lblType;
        private Label lblName;
        private ListView lvAnimals;
        private ComboBox cbType;
        private Label btnEdit;
    }
}