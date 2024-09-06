namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtbxAlbumName = new TextBox();
            txtbxSinger = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtbxPrice = new TextBox();
            label4 = new Label();
            txtbxDiscount = new TextBox();
            label5 = new Label();
            listView1 = new ListView();
            cmbxFiltered = new ComboBox();
            cmbxCategory = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtbxPassword1 = new TextBox();
            txtbxUsername = new TextBox();
            btnCreateUser = new Button();
            label9 = new Label();
            txtbxPassword2 = new TextBox();
            cmbStatus = new ComboBox();
            label10 = new Label();
            txtId = new TextBox();
            label11 = new Label();
            chckClear = new CheckBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Window;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.ForeColor = SystemColors.WindowText;
            btnAdd.Location = new Point(7, 342);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 37);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Window;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.ForeColor = SystemColors.WindowText;
            btnUpdate.Location = new Point(126, 342);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 37);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Window;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.ForeColor = SystemColors.WindowText;
            btnDelete.Location = new Point(239, 342);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 37);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtbxAlbumName
            // 
            txtbxAlbumName.BackColor = SystemColors.Window;
            txtbxAlbumName.Location = new Point(111, 49);
            txtbxAlbumName.Margin = new Padding(4, 3, 4, 3);
            txtbxAlbumName.Name = "txtbxAlbumName";
            txtbxAlbumName.Size = new Size(214, 23);
            txtbxAlbumName.TabIndex = 4;
            // 
            // txtbxSinger
            // 
            txtbxSinger.BackColor = SystemColors.Window;
            txtbxSinger.Location = new Point(111, 93);
            txtbxSinger.Margin = new Padding(4, 3, 4, 3);
            txtbxSinger.Name = "txtbxSinger";
            txtbxSinger.Size = new Size(214, 23);
            txtbxSinger.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(4, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 6;
            label1.Text = "Album Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(4, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 7;
            label2.Text = "Artist/Group:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(4, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 8;
            label3.Text = "Release Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Crimson;
            dateTimePicker1.CalendarMonthBackground = Color.Gainsboro;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.Window;
            dateTimePicker1.Location = new Point(111, 131);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(214, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // txtbxPrice
            // 
            txtbxPrice.BackColor = SystemColors.Window;
            txtbxPrice.Location = new Point(111, 210);
            txtbxPrice.Margin = new Padding(4, 3, 4, 3);
            txtbxPrice.Name = "txtbxPrice";
            txtbxPrice.Size = new Size(214, 23);
            txtbxPrice.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(4, 218);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 12;
            label4.Text = "Price:";
            // 
            // txtbxDiscount
            // 
            txtbxDiscount.BackColor = SystemColors.Window;
            txtbxDiscount.Location = new Point(111, 248);
            txtbxDiscount.Margin = new Padding(4, 3, 4, 3);
            txtbxDiscount.Name = "txtbxDiscount";
            txtbxDiscount.Size = new Size(214, 23);
            txtbxDiscount.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(4, 256);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 14;
            label5.Text = "Discount Rate:";
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Window;
            listView1.FullRowSelect = true;
            listView1.Location = new Point(333, 38);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(675, 310);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // cmbxFiltered
            // 
            cmbxFiltered.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxFiltered.FormattingEnabled = true;
            cmbxFiltered.Location = new Point(401, 9);
            cmbxFiltered.Margin = new Padding(4, 3, 4, 3);
            cmbxFiltered.Name = "cmbxFiltered";
            cmbxFiltered.Size = new Size(272, 23);
            cmbxFiltered.TabIndex = 16;
            cmbxFiltered.SelectedIndexChanged += cmbxFiltered_SelectedIndexChanged;
            // 
            // cmbxCategory
            // 
            cmbxCategory.BackColor = SystemColors.Window;
            cmbxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxCategory.FormattingEnabled = true;
            cmbxCategory.Location = new Point(111, 171);
            cmbxCategory.Margin = new Padding(4, 3, 4, 3);
            cmbxCategory.Name = "cmbxCategory";
            cmbxCategory.Size = new Size(214, 23);
            cmbxCategory.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(4, 179);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 18;
            label6.Text = "Genre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(7, 481);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 22;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(7, 441);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 21;
            label8.Text = "Username";
            // 
            // txtbxPassword1
            // 
            txtbxPassword1.BackColor = SystemColors.Window;
            txtbxPassword1.Location = new Point(99, 473);
            txtbxPassword1.Margin = new Padding(4, 3, 4, 3);
            txtbxPassword1.Name = "txtbxPassword1";
            txtbxPassword1.Size = new Size(214, 23);
            txtbxPassword1.TabIndex = 20;
            // 
            // txtbxUsername
            // 
            txtbxUsername.BackColor = SystemColors.Window;
            txtbxUsername.Location = new Point(99, 432);
            txtbxUsername.Margin = new Padding(4, 3, 4, 3);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.Size = new Size(214, 23);
            txtbxUsername.TabIndex = 19;
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = SystemColors.Window;
            btnCreateUser.FlatStyle = FlatStyle.Popup;
            btnCreateUser.ForeColor = SystemColors.WindowText;
            btnCreateUser.Location = new Point(320, 431);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(70, 108);
            btnCreateUser.TabIndex = 23;
            btnCreateUser.Text = "Add New User";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(7, 522);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 24;
            label9.Text = "Password ";
            // 
            // txtbxPassword2
            // 
            txtbxPassword2.BackColor = SystemColors.Window;
            txtbxPassword2.Location = new Point(99, 515);
            txtbxPassword2.Margin = new Padding(4, 3, 4, 3);
            txtbxPassword2.Name = "txtbxPassword2";
            txtbxPassword2.Size = new Size(214, 23);
            txtbxPassword2.TabIndex = 25;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = SystemColors.Window;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(111, 288);
            cmbStatus.Margin = new Padding(4, 3, 4, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(214, 23);
            cmbStatus.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(4, 296);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 14;
            label10.Text = "Status:";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.Window;
            txtId.Location = new Point(111, 12);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.Size = new Size(214, 23);
            txtId.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(4, 20);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 6;
            label11.Text = "Id:";
            // 
            // chckClear
            // 
            chckClear.AutoSize = true;
            chckClear.BackColor = Color.Transparent;
            chckClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chckClear.ForeColor = SystemColors.ActiveCaptionText;
            chckClear.Location = new Point(334, 352);
            chckClear.Name = "chckClear";
            chckClear.Size = new Size(114, 19);
            chckClear.TabIndex = 26;
            chckClear.Text = "Clear Selections";
            chckClear.UseVisualStyleBackColor = false;
            chckClear.CheckedChanged += chckClear_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(334, 17);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 27;
            label12.Text = "Reports : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1013, 569);
            Controls.Add(label12);
            Controls.Add(chckClear);
            Controls.Add(txtbxPassword2);
            Controls.Add(label9);
            Controls.Add(btnCreateUser);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtbxPassword1);
            Controls.Add(txtbxUsername);
            Controls.Add(label6);
            Controls.Add(cmbStatus);
            Controls.Add(cmbxCategory);
            Controls.Add(cmbxFiltered);
            Controls.Add(listView1);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(txtbxDiscount);
            Controls.Add(label4);
            Controls.Add(txtbxPrice);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label11);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(txtbxSinger);
            Controls.Add(txtbxAlbumName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtbxAlbumName;
        private System.Windows.Forms.TextBox txtbxSinger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cmbxFiltered;
        private System.Windows.Forms.ComboBox cmbxCategory;
        private System.Windows.Forms.Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtbxPassword1;
        private TextBox txtbxUsername;
        private Button btnCreateUser;
        private Label label9;
        private TextBox txtbxPassword2;
        private ComboBox cmbStatus;
        private Label label10;
        private TextBox txtId;
        private Label label11;
        private CheckBox chckClear;
        private Label label12;
    }
}

