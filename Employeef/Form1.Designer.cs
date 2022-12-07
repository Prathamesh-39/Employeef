
namespace Employeef
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
            this.btnGetall = new System.Windows.Forms.Button();
            this.btnGetname = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnget = new System.Windows.Forms.Button();
            this.Postbtn = new System.Windows.Forms.Button();
            this.txtpage = new System.Windows.Forms.TextBox();
            this.txtresponse = new System.Windows.Forms.RichTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtdel = new System.Windows.Forms.TextBox();
            this.postname = new System.Windows.Forms.TextBox();
            this.postemail = new System.Windows.Forms.TextBox();
            this.postgen = new System.Windows.Forms.TextBox();
            this.poststa = new System.Windows.Forms.TextBox();
            this.Employee = new System.Windows.Forms.Label();
            this.txtGname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnexp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnput = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetall
            // 
            this.btnGetall.Location = new System.Drawing.Point(34, 69);
            this.btnGetall.Name = "btnGetall";
            this.btnGetall.Size = new System.Drawing.Size(149, 61);
            this.btnGetall.TabIndex = 0;
            this.btnGetall.Text = "Get All Details";
            this.btnGetall.UseVisualStyleBackColor = true;
            this.btnGetall.Click += new System.EventHandler(this.btnGetall_Click);
            // 
            // btnGetname
            // 
            this.btnGetname.Location = new System.Drawing.Point(34, 318);
            this.btnGetname.Name = "btnGetname";
            this.btnGetname.Size = new System.Drawing.Size(88, 47);
            this.btnGetname.TabIndex = 1;
            this.btnGetname.Text = "Search (Name)";
            this.btnGetname.UseVisualStyleBackColor = true;
            this.btnGetname.Click += new System.EventHandler(this.btnGetname_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(730, 69);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 35);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnget
            // 
            this.btnget.Location = new System.Drawing.Point(34, 245);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(75, 45);
            this.btnget.TabIndex = 3;
            this.btnget.Text = "Search (ID)";
            this.btnget.UseVisualStyleBackColor = true;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // Postbtn
            // 
            this.Postbtn.Location = new System.Drawing.Point(730, 167);
            this.Postbtn.Name = "Postbtn";
            this.Postbtn.Size = new System.Drawing.Size(75, 30);
            this.Postbtn.TabIndex = 4;
            this.Postbtn.Text = "Post";
            this.Postbtn.UseVisualStyleBackColor = true;
            this.Postbtn.Click += new System.EventHandler(this.Postbtn_Click);
            // 
            // txtpage
            // 
            this.txtpage.Location = new System.Drawing.Point(181, 158);
            this.txtpage.Name = "txtpage";
            this.txtpage.Size = new System.Drawing.Size(98, 22);
            this.txtpage.TabIndex = 5;
            // 
            // txtresponse
            // 
            this.txtresponse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtresponse.Location = new System.Drawing.Point(315, 40);
            this.txtresponse.Name = "txtresponse";
            this.txtresponse.ReadOnly = true;
            this.txtresponse.Size = new System.Drawing.Size(363, 467);
            this.txtresponse.TabIndex = 6;
            this.txtresponse.Text = "";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(181, 247);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 7;
            // 
            // txtdel
            // 
            this.txtdel.Location = new System.Drawing.Point(939, 69);
            this.txtdel.Name = "txtdel";
            this.txtdel.Size = new System.Drawing.Size(100, 22);
            this.txtdel.TabIndex = 8;
            // 
            // postname
            // 
            this.postname.Location = new System.Drawing.Point(939, 142);
            this.postname.Name = "postname";
            this.postname.Size = new System.Drawing.Size(100, 22);
            this.postname.TabIndex = 9;
            // 
            // postemail
            // 
            this.postemail.Location = new System.Drawing.Point(939, 192);
            this.postemail.Name = "postemail";
            this.postemail.Size = new System.Drawing.Size(100, 22);
            this.postemail.TabIndex = 10;
            // 
            // postgen
            // 
            this.postgen.Location = new System.Drawing.Point(939, 247);
            this.postgen.Name = "postgen";
            this.postgen.Size = new System.Drawing.Size(100, 22);
            this.postgen.TabIndex = 11;
            // 
            // poststa
            // 
            this.poststa.Location = new System.Drawing.Point(939, 297);
            this.poststa.Name = "poststa";
            this.poststa.Size = new System.Drawing.Size(100, 22);
            this.poststa.TabIndex = 12;
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(30, 20);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(156, 20);
            this.Employee.TabIndex = 13;
            this.Employee.Text = "Employee Details";
            // 
            // txtGname
            // 
            this.txtGname.Location = new System.Drawing.Point(181, 324);
            this.txtGname.Name = "txtGname";
            this.txtGname.Size = new System.Drawing.Size(100, 22);
            this.txtGname.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(859, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(859, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(859, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(859, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(862, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID";
            // 
            // btnexp
            // 
            this.btnexp.Location = new System.Drawing.Point(970, 516);
            this.btnexp.Name = "btnexp";
            this.btnexp.Size = new System.Drawing.Size(98, 23);
            this.btnexp.TabIndex = 20;
            this.btnexp.Text = "Export_test";
            this.btnexp.UseVisualStyleBackColor = true;
            this.btnexp.Click += new System.EventHandler(this.btnexp_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(908, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnput
            // 
            this.btnput.Location = new System.Drawing.Point(730, 245);
            this.btnput.Name = "btnput";
            this.btnput.Size = new System.Drawing.Size(75, 33);
            this.btnput.TabIndex = 22;
            this.btnput.Text = "Update";
            this.btnput.UseVisualStyleBackColor = true;
            this.btnput.Click += new System.EventHandler(this.btnput_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Page No.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGname);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.poststa);
            this.Controls.Add(this.postgen);
            this.Controls.Add(this.postemail);
            this.Controls.Add(this.postname);
            this.Controls.Add(this.txtdel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtresponse);
            this.Controls.Add(this.txtpage);
            this.Controls.Add(this.Postbtn);
            this.Controls.Add(this.btnget);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnGetname);
            this.Controls.Add(this.btnGetall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetall;
        private System.Windows.Forms.Button btnGetname;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.Button Postbtn;
        private System.Windows.Forms.TextBox txtpage;
        private System.Windows.Forms.RichTextBox txtresponse;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtdel;
        private System.Windows.Forms.TextBox postname;
        private System.Windows.Forms.TextBox postemail;
        private System.Windows.Forms.TextBox postgen;
        private System.Windows.Forms.TextBox poststa;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.TextBox txtGname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnexp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnput;
        private System.Windows.Forms.Label label6;
    }
}

