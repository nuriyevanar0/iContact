namespace ContactBookWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstnameLB = new System.Windows.Forms.Label();
            this.surnameLB = new System.Windows.Forms.Label();
            this.phoneNumLB = new System.Windows.Forms.Label();
            this.emailLB = new System.Windows.Forms.Label();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.phoneNumTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.contactsDataGrid = new System.Windows.Forms.DataGridView();
            this.dateOfBirthClndr = new System.Windows.Forms.DateTimePicker();
            this.birthdayLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.infoLB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userLB = new System.Windows.Forms.Label();
            this.searchBT = new System.Windows.Forms.Button();
            this.datagridBrthdy = new System.Windows.Forms.DataGridView();
            this.comingBirthdaysLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBrthdy)).BeginInit();
            this.SuspendLayout();
            // 
            // firstnameLB
            // 
            this.firstnameLB.AutoSize = true;
            this.firstnameLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstnameLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstnameLB.Location = new System.Drawing.Point(29, 132);
            this.firstnameLB.Name = "firstnameLB";
            this.firstnameLB.Size = new System.Drawing.Size(97, 28);
            this.firstnameLB.TabIndex = 0;
            this.firstnameLB.Text = "Firstname";
            // 
            // surnameLB
            // 
            this.surnameLB.AutoSize = true;
            this.surnameLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.surnameLB.Location = new System.Drawing.Point(29, 168);
            this.surnameLB.Name = "surnameLB";
            this.surnameLB.Size = new System.Drawing.Size(89, 28);
            this.surnameLB.TabIndex = 1;
            this.surnameLB.Text = "Surname";
            // 
            // phoneNumLB
            // 
            this.phoneNumLB.AutoSize = true;
            this.phoneNumLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneNumLB.Location = new System.Drawing.Point(29, 204);
            this.phoneNumLB.Name = "phoneNumLB";
            this.phoneNumLB.Size = new System.Drawing.Size(144, 28);
            this.phoneNumLB.TabIndex = 2;
            this.phoneNumLB.Text = "Phone Number";
            // 
            // emailLB
            // 
            this.emailLB.AutoSize = true;
            this.emailLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailLB.Location = new System.Drawing.Point(29, 240);
            this.emailLB.Name = "emailLB";
            this.emailLB.Size = new System.Drawing.Size(67, 28);
            this.emailLB.TabIndex = 3;
            this.emailLB.Text = "E-mail";
            // 
            // firstnameTB
            // 
            this.firstnameTB.Location = new System.Drawing.Point(166, 129);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(316, 27);
            this.firstnameTB.TabIndex = 4;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(166, 165);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(316, 27);
            this.surnameTB.TabIndex = 5;
            // 
            // phoneNumTB
            // 
            this.phoneNumTB.Location = new System.Drawing.Point(166, 201);
            this.phoneNumTB.Name = "phoneNumTB";
            this.phoneNumTB.Size = new System.Drawing.Size(316, 27);
            this.phoneNumTB.TabIndex = 6;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(166, 237);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(316, 27);
            this.emailTB.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(366, 407);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(117, 29);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(64, 425);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(117, 29);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(64, 391);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(117, 29);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // contactsDataGrid
            // 
            this.contactsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsDataGrid.Location = new System.Drawing.Point(499, 236);
            this.contactsDataGrid.Name = "contactsDataGrid";
            this.contactsDataGrid.RowHeadersWidth = 51;
            this.contactsDataGrid.RowTemplate.Height = 29;
            this.contactsDataGrid.Size = new System.Drawing.Size(744, 219);
            this.contactsDataGrid.TabIndex = 12;
            this.contactsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contactsDataGrid_CellClick);
            // 
            // dateOfBirthClndr
            // 
            this.dateOfBirthClndr.Location = new System.Drawing.Point(166, 292);
            this.dateOfBirthClndr.Name = "dateOfBirthClndr";
            this.dateOfBirthClndr.Size = new System.Drawing.Size(273, 27);
            this.dateOfBirthClndr.TabIndex = 14;
            // 
            // birthdayLB
            // 
            this.birthdayLB.AutoSize = true;
            this.birthdayLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthdayLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.birthdayLB.Location = new System.Drawing.Point(29, 292);
            this.birthdayLB.Name = "birthdayLB";
            this.birthdayLB.Size = new System.Drawing.Size(85, 28);
            this.birthdayLB.TabIndex = 15;
            this.birthdayLB.Text = "Birthday";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(247, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 41);
            this.label1.TabIndex = 17;
            this.label1.Text = "iContact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(489, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "Your Contacts";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(64, 349);
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(116, 27);
            this.idTB.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(29, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "ID";
            // 
            // infoLB
            // 
            this.infoLB.AutoSize = true;
            this.infoLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoLB.Location = new System.Drawing.Point(240, 355);
            this.infoLB.Name = "infoLB";
            this.infoLB.Size = new System.Drawing.Size(0, 28);
            this.infoLB.TabIndex = 21;
            this.infoLB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(187, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Info:";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(247, 407);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(117, 29);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(499, 135);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(620, 27);
            this.searchTB.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(499, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "User:";
            // 
            // userLB
            // 
            this.userLB.AutoSize = true;
            this.userLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLB.Location = new System.Drawing.Point(565, 184);
            this.userLB.Name = "userLB";
            this.userLB.Size = new System.Drawing.Size(0, 28);
            this.userLB.TabIndex = 27;
            this.userLB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // searchBT
            // 
            this.searchBT.Location = new System.Drawing.Point(1127, 136);
            this.searchBT.Name = "searchBT";
            this.searchBT.Size = new System.Drawing.Size(117, 29);
            this.searchBT.TabIndex = 28;
            this.searchBT.Text = "Search";
            this.searchBT.UseVisualStyleBackColor = true;
            this.searchBT.Click += new System.EventHandler(this.searchBT_Click);
            // 
            // datagridBrthdy
            // 
            this.datagridBrthdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBrthdy.Location = new System.Drawing.Point(64, 555);
            this.datagridBrthdy.Name = "datagridBrthdy";
            this.datagridBrthdy.RowHeadersWidth = 51;
            this.datagridBrthdy.RowTemplate.Height = 29;
            this.datagridBrthdy.Size = new System.Drawing.Size(821, 188);
            this.datagridBrthdy.TabIndex = 29;
            // 
            // comingBirthdaysLB
            // 
            this.comingBirthdaysLB.AutoSize = true;
            this.comingBirthdaysLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comingBirthdaysLB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comingBirthdaysLB.Location = new System.Drawing.Point(64, 494);
            this.comingBirthdaysLB.Name = "comingBirthdaysLB";
            this.comingBirthdaysLB.Size = new System.Drawing.Size(343, 41);
            this.comingBirthdaysLB.TabIndex = 30;
            this.comingBirthdaysLB.Text = "Next coming birthdays";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1262, 819);
            this.Controls.Add(this.comingBirthdaysLB);
            this.Controls.Add(this.datagridBrthdy);
            this.Controls.Add(this.searchBT);
            this.Controls.Add(this.userLB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.infoLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.birthdayLB);
            this.Controls.Add(this.dateOfBirthClndr);
            this.Controls.Add(this.contactsDataGrid);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.phoneNumTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.firstnameTB);
            this.Controls.Add(this.emailLB);
            this.Controls.Add(this.phoneNumLB);
            this.Controls.Add(this.surnameLB);
            this.Controls.Add(this.firstnameLB);
            this.Name = "Form1";
            this.Text = "ContactBook";
            ((System.ComponentModel.ISupportInitialize)(this.contactsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBrthdy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstnameLB;
        private Label surnameLB;
        private Label phoneNumLB;
        private Label emailLB;
        private TextBox firstnameTB;
        private TextBox surnameTB;
        private TextBox phoneNumTB;
        private TextBox emailTB;
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private DataGridView contactsDataGrid;
        private DateTimePicker dateOfBirthClndr;
        private Label birthdayLB;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox idTB;
        private Label label3;
        private Label infoLB;
        private Label label4;
        private Button refreshBtn;
        private TextBox searchTB;
        private Label label5;
        private Label userLB;
        private Button searchBT;
        private DataGridView datagridBrthdy;
        private Label comingBirthdaysLB;
    }
}