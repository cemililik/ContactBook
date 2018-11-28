namespace ContactBook.App
{
    partial class MainPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_list = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add_contact = new System.Windows.Forms.Button();
            this.txt_new_email = new System.Windows.Forms.TextBox();
            this.txt_new_surname = new System.Windows.Forms.TextBox();
            this.txt_new_number3 = new System.Windows.Forms.TextBox();
            this.txt_new_number2 = new System.Windows.Forms.TextBox();
            this.txt_new_info = new System.Windows.Forms.TextBox();
            this.txt_new_adress = new System.Windows.Forms.TextBox();
            this.txt_new_webadress = new System.Windows.Forms.TextBox();
            this.txt_new_number1 = new System.Windows.Forms.TextBox();
            this.txt_new_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_update_email = new System.Windows.Forms.TextBox();
            this.txt_update_surname = new System.Windows.Forms.TextBox();
            this.txt_update_number3 = new System.Windows.Forms.TextBox();
            this.txt_update_number2 = new System.Windows.Forms.TextBox();
            this.txt_update_adress = new System.Windows.Forms.TextBox();
            this.txt_update_info = new System.Windows.Forms.TextBox();
            this.txt_update_webadress = new System.Windows.Forms.TextBox();
            this.txt_update_number1 = new System.Windows.Forms.TextBox();
            this.txt_update_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_list);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List";
            // 
            // lst_list
            // 
            this.lst_list.FormattingEnabled = true;
            this.lst_list.Location = new System.Drawing.Point(9, 16);
            this.lst_list.Name = "lst_list";
            this.lst_list.Size = new System.Drawing.Size(253, 485);
            this.lst_list.TabIndex = 0;
            this.lst_list.SelectedIndexChanged += new System.EventHandler(this.lst_list_SelectedIndexChanged);
            this.lst_list.DoubleClick += new System.EventHandler(this.lst_list_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_add_contact);
            this.groupBox2.Controls.Add(this.txt_new_email);
            this.groupBox2.Controls.Add(this.txt_new_surname);
            this.groupBox2.Controls.Add(this.txt_new_number3);
            this.groupBox2.Controls.Add(this.txt_new_number2);
            this.groupBox2.Controls.Add(this.txt_new_info);
            this.groupBox2.Controls.Add(this.txt_new_adress);
            this.groupBox2.Controls.Add(this.txt_new_webadress);
            this.groupBox2.Controls.Add(this.txt_new_number1);
            this.groupBox2.Controls.Add(this.txt_new_name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(306, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Contact";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(383, 201);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(372, 34);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add_contact
            // 
            this.btn_add_contact.Location = new System.Drawing.Point(9, 201);
            this.btn_add_contact.Name = "btn_add_contact";
            this.btn_add_contact.Size = new System.Drawing.Size(372, 34);
            this.btn_add_contact.TabIndex = 9;
            this.btn_add_contact.Text = "Add Contact";
            this.btn_add_contact.UseVisualStyleBackColor = true;
            this.btn_add_contact.Click += new System.EventHandler(this.btn_add_contact_Click);
            // 
            // txt_new_email
            // 
            this.txt_new_email.Location = new System.Drawing.Point(82, 97);
            this.txt_new_email.Name = "txt_new_email";
            this.txt_new_email.Size = new System.Drawing.Size(147, 20);
            this.txt_new_email.TabIndex = 2;
            // 
            // txt_new_surname
            // 
            this.txt_new_surname.Location = new System.Drawing.Point(82, 64);
            this.txt_new_surname.Name = "txt_new_surname";
            this.txt_new_surname.Size = new System.Drawing.Size(147, 20);
            this.txt_new_surname.TabIndex = 1;
            // 
            // txt_new_number3
            // 
            this.txt_new_number3.Location = new System.Drawing.Point(341, 97);
            this.txt_new_number3.Name = "txt_new_number3";
            this.txt_new_number3.Size = new System.Drawing.Size(147, 20);
            this.txt_new_number3.TabIndex = 5;
            // 
            // txt_new_number2
            // 
            this.txt_new_number2.Location = new System.Drawing.Point(341, 64);
            this.txt_new_number2.Name = "txt_new_number2";
            this.txt_new_number2.Size = new System.Drawing.Size(147, 20);
            this.txt_new_number2.TabIndex = 4;
            // 
            // txt_new_info
            // 
            this.txt_new_info.Location = new System.Drawing.Point(82, 137);
            this.txt_new_info.Multiline = true;
            this.txt_new_info.Name = "txt_new_info";
            this.txt_new_info.Size = new System.Drawing.Size(673, 53);
            this.txt_new_info.TabIndex = 8;
            // 
            // txt_new_adress
            // 
            this.txt_new_adress.Location = new System.Drawing.Point(608, 64);
            this.txt_new_adress.Multiline = true;
            this.txt_new_adress.Name = "txt_new_adress";
            this.txt_new_adress.Size = new System.Drawing.Size(147, 53);
            this.txt_new_adress.TabIndex = 7;
            // 
            // txt_new_webadress
            // 
            this.txt_new_webadress.Location = new System.Drawing.Point(608, 34);
            this.txt_new_webadress.Name = "txt_new_webadress";
            this.txt_new_webadress.Size = new System.Drawing.Size(147, 20);
            this.txt_new_webadress.TabIndex = 6;
            // 
            // txt_new_number1
            // 
            this.txt_new_number1.Location = new System.Drawing.Point(341, 34);
            this.txt_new_number1.Name = "txt_new_number1";
            this.txt_new_number1.Size = new System.Drawing.Size(147, 20);
            this.txt_new_number1.TabIndex = 3;
            // 
            // txt_new_name
            // 
            this.txt_new_name.Location = new System.Drawing.Point(82, 34);
            this.txt_new_name.Name = "txt_new_name";
            this.txt_new_name.Size = new System.Drawing.Size(147, 20);
            this.txt_new_name.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email Adress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Number III";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Info";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(532, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Adress";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Web Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number II";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number I";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.txt_update_email);
            this.groupBox3.Controls.Add(this.txt_update_surname);
            this.groupBox3.Controls.Add(this.txt_update_number3);
            this.groupBox3.Controls.Add(this.txt_update_number2);
            this.groupBox3.Controls.Add(this.txt_update_adress);
            this.groupBox3.Controls.Add(this.txt_update_info);
            this.groupBox3.Controls.Add(this.txt_update_webadress);
            this.groupBox3.Controls.Add(this.txt_update_number1);
            this.groupBox3.Controls.Add(this.txt_update_name);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(306, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(770, 249);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update/DeleteContact";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(410, 196);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(345, 34);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete Contact";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(9, 196);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(345, 34);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Update Contact";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_update_email
            // 
            this.txt_update_email.Location = new System.Drawing.Point(82, 97);
            this.txt_update_email.Name = "txt_update_email";
            this.txt_update_email.Size = new System.Drawing.Size(147, 20);
            this.txt_update_email.TabIndex = 12;
            // 
            // txt_update_surname
            // 
            this.txt_update_surname.Location = new System.Drawing.Point(82, 64);
            this.txt_update_surname.Name = "txt_update_surname";
            this.txt_update_surname.Size = new System.Drawing.Size(147, 20);
            this.txt_update_surname.TabIndex = 11;
            // 
            // txt_update_number3
            // 
            this.txt_update_number3.Location = new System.Drawing.Point(341, 97);
            this.txt_update_number3.Name = "txt_update_number3";
            this.txt_update_number3.Size = new System.Drawing.Size(147, 20);
            this.txt_update_number3.TabIndex = 15;
            // 
            // txt_update_number2
            // 
            this.txt_update_number2.Location = new System.Drawing.Point(341, 64);
            this.txt_update_number2.Name = "txt_update_number2";
            this.txt_update_number2.Size = new System.Drawing.Size(147, 20);
            this.txt_update_number2.TabIndex = 14;
            // 
            // txt_update_adress
            // 
            this.txt_update_adress.Location = new System.Drawing.Point(608, 64);
            this.txt_update_adress.Multiline = true;
            this.txt_update_adress.Name = "txt_update_adress";
            this.txt_update_adress.Size = new System.Drawing.Size(147, 53);
            this.txt_update_adress.TabIndex = 17;
            // 
            // txt_update_info
            // 
            this.txt_update_info.Location = new System.Drawing.Point(82, 137);
            this.txt_update_info.Multiline = true;
            this.txt_update_info.Name = "txt_update_info";
            this.txt_update_info.Size = new System.Drawing.Size(673, 53);
            this.txt_update_info.TabIndex = 18;
            // 
            // txt_update_webadress
            // 
            this.txt_update_webadress.Location = new System.Drawing.Point(608, 34);
            this.txt_update_webadress.Name = "txt_update_webadress";
            this.txt_update_webadress.Size = new System.Drawing.Size(147, 20);
            this.txt_update_webadress.TabIndex = 16;
            // 
            // txt_update_number1
            // 
            this.txt_update_number1.Location = new System.Drawing.Point(341, 34);
            this.txt_update_number1.Name = "txt_update_number1";
            this.txt_update_number1.Size = new System.Drawing.Size(147, 20);
            this.txt_update_number1.TabIndex = 13;
            // 
            // txt_update_name
            // 
            this.txt_update_name.Location = new System.Drawing.Point(82, 34);
            this.txt_update_name.Name = "txt_update_name";
            this.txt_update_name.Size = new System.Drawing.Size(147, 20);
            this.txt_update_name.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Email Adress";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Surname";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Number III";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Info";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(532, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Adress";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(532, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Web Adress";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(265, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Number II";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Number I";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Name";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 538);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_list;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_new_email;
        private System.Windows.Forms.TextBox txt_new_surname;
        private System.Windows.Forms.TextBox txt_new_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_contact;
        private System.Windows.Forms.TextBox txt_new_number3;
        private System.Windows.Forms.TextBox txt_new_number2;
        private System.Windows.Forms.TextBox txt_new_info;
        private System.Windows.Forms.TextBox txt_new_adress;
        private System.Windows.Forms.TextBox txt_new_webadress;
        private System.Windows.Forms.TextBox txt_new_number1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_update_email;
        private System.Windows.Forms.TextBox txt_update_surname;
        private System.Windows.Forms.TextBox txt_update_number3;
        private System.Windows.Forms.TextBox txt_update_number2;
        private System.Windows.Forms.TextBox txt_update_adress;
        private System.Windows.Forms.TextBox txt_update_info;
        private System.Windows.Forms.TextBox txt_update_webadress;
        private System.Windows.Forms.TextBox txt_update_number1;
        private System.Windows.Forms.TextBox txt_update_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_clear;
    }
}