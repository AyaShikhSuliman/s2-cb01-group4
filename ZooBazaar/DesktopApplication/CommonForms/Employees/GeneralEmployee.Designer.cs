namespace DesktopApplication.Adminstration
{
    partial class EmployeeGeneralForm
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
            this.btnPromote = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.lvEmployees = new System.Windows.Forms.ListView();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBackground
            // 
            this.pcBackground.Image = global::DesktopApplication.Properties.Resources.animal_general;
            this.pcBackground.Location = new System.Drawing.Point(-28, -4);
            this.pcBackground.Name = "pcBackground";
            this.pcBackground.Size = new System.Drawing.Size(1079, 643);
            this.pcBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBackground.TabIndex = 1;
            this.pcBackground.TabStop = false;
            // 
            // btnPromote
            // 
            this.btnPromote.AutoSize = true;
            this.btnPromote.BackColor = System.Drawing.Color.Transparent;
            this.btnPromote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPromote.ForeColor = System.Drawing.Color.White;
            this.btnPromote.Image = global::DesktopApplication.Properties.Resources.btn;
            this.btnPromote.Location = new System.Drawing.Point(65, 410);
            this.btnPromote.Name = "btnPromote";
            this.btnPromote.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btnPromote.Size = new System.Drawing.Size(80, 20);
            this.btnPromote.TabIndex = 4;
            this.btnPromote.Text = "Promote";
            this.btnPromote.Click += new System.EventHandler(this.btnPromote_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = global::DesktopApplication.Properties.Resources.btn;
            this.btnRemove.Location = new System.Drawing.Point(65, 452);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(10, 0, 7, 0);
            this.btnRemove.Size = new System.Drawing.Size(80, 20);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(69, 363);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(21, 0, 23, 0);
            this.btnEdit.Size = new System.Drawing.Size(79, 20);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.SaddleBrown;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Location = new System.Drawing.Point(300, 94);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(111, 27);
            this.tbName.TabIndex = 10;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.SaddleBrown;
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbID.Location = new System.Drawing.Point(640, 94);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(116, 27);
            this.tbID.TabIndex = 11;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.SaddleBrown;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Location = new System.Drawing.Point(482, 94);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(110, 27);
            this.tbEmail.TabIndex = 12;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 20;
            this.lbInfo.Location = new System.Drawing.Point(261, 172);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(553, 404);
            this.lbInfo.TabIndex = 13;
            // 
            // lvEmployees
            // 
            this.lvEmployees.FullRowSelect = true;
            this.lvEmployees.HoverSelection = true;
            this.lvEmployees.Location = new System.Drawing.Point(239, 163);
            this.lvEmployees.Name = "lvEmployees";
            this.lvEmployees.Size = new System.Drawing.Size(586, 419);
            this.lvEmployees.TabIndex = 15;
            this.lvEmployees.UseCompatibleStateImageBehavior = false;
            this.lvEmployees.SelectedIndexChanged += new System.EventHandler(this.lvEmployees_SelectedIndexChanged);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdd.ForeColor = System.Drawing.Color.White;
            this.lblAdd.Image = global::DesktopApplication.Properties.Resources.btn;
            this.lblAdd.Location = new System.Drawing.Point(64, 496);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Padding = new System.Windows.Forms.Padding(21, 0, 23, 0);
            this.lblAdd.Size = new System.Drawing.Size(81, 20);
            this.lblAdd.TabIndex = 16;
            this.lblAdd.Text = "Add";
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.SkyBlue;
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(239, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 20);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.SkyBlue;
            this.lblEmail.Location = new System.Drawing.Point(427, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.SkyBlue;
            this.lblID.Location = new System.Drawing.Point(607, 97);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 20);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID:";
            // 
            // EmployeeGeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lvEmployees);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPromote);
            this.Controls.Add(this.pcBackground);
            this.Name = "EmployeeGeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee General";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeGeneralForm_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeGeneralForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcBackground;
        private Label btnPromote;
        private Label btnRemove;
        private Label btnEdit;
        private TextBox tbName;
        private TextBox tbID;
        private TextBox tbEmail;
        private ListBox lbInfo;
        private ListView lvEmployees;
        private Label lblAdd;
        private Label lblName;
        private Label lblEmail;
        private Label lblID;
    }
}