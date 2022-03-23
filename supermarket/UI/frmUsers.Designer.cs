
namespace supermarket.UI
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_box = new System.Windows.Forms.PictureBox();
            this.users_label = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.permissionlabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.user_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_box)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.close_box);
            this.panel1.Controls.Add(this.users_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 73);
            this.panel1.TabIndex = 0;
            // 
            // close_box
            // 
            this.close_box.Image = ((System.Drawing.Image)(resources.GetObject("close_box.Image")));
            this.close_box.Location = new System.Drawing.Point(0, 0);
            this.close_box.Name = "close_box";
            this.close_box.Size = new System.Drawing.Size(40, 39);
            this.close_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_box.TabIndex = 1;
            this.close_box.TabStop = false;
            this.close_box.Click += new System.EventHandler(this.close_box_Click);
            // 
            // users_label
            // 
            this.users_label.AutoSize = true;
            this.users_label.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.users_label.Location = new System.Drawing.Point(357, 23);
            this.users_label.Name = "users_label";
            this.users_label.Size = new System.Drawing.Size(129, 31);
            this.users_label.TabIndex = 0;
            this.users_label.Text = "المستخدمين";
            this.users_label.Click += new System.EventHandler(this.users_label_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.Location = new System.Drawing.Point(655, 138);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(133, 28);
            this.userName.TabIndex = 1;
            this.userName.Text = "اسم المستخدم";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(683, 189);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(104, 28);
            this.password.TabIndex = 2;
            this.password.Text = "كلمة المرور";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone.Location = new System.Drawing.Point(689, 237);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(99, 28);
            this.phone.TabIndex = 3;
            this.phone.Text = "رقم الهاتف";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(645, 288);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(144, 28);
            this.email.TabIndex = 4;
            this.email.Text = "البريد الإلكتروني";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(456, 142);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(171, 27);
            this.name_textbox.TabIndex = 5;
            this.name_textbox.TextChanged += new System.EventHandler(this.name_textbox_TextChanged);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(456, 193);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(171, 27);
            this.password_textbox.TabIndex = 6;
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(456, 241);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(171, 27);
            this.phone_textbox.TabIndex = 7;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(456, 292);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(171, 27);
            this.email_textbox.TabIndex = 8;
            // 
            // permissionlabel
            // 
            this.permissionlabel.AutoSize = true;
            this.permissionlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.permissionlabel.Location = new System.Drawing.Point(689, 341);
            this.permissionlabel.Name = "permissionlabel";
            this.permissionlabel.Size = new System.Drawing.Size(98, 28);
            this.permissionlabel.TabIndex = 9;
            this.permissionlabel.Text = "الصلاحيات";
            this.permissionlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "أدمن",
            "مستخدم"});
            this.comboBox1.Location = new System.Drawing.Point(456, 345);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 28);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.Snow;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_button.Location = new System.Drawing.Point(144, 353);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(144, 47);
            this.add_button.TabIndex = 11;
            this.add_button.Text = "إضافة";
            this.add_button.UseVisualStyleBackColor = false;
            // 
            // user_id
            // 
            this.user_id.AccessibleName = "user_id";
            this.user_id.Location = new System.Drawing.Point(456, 98);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(171, 27);
            this.user_id.TabIndex = 13;
            this.user_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AccessibleName = "user_id";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(655, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "رقم المستخدم";
            // 
            // frmUsers
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.permissionlabel);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label users_label;
        private System.Windows.Forms.PictureBox close_box;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label permissionlabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.Label label1;
    }
}