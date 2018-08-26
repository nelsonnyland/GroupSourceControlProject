﻿namespace GroupSourceControlProject.Forms
{
    partial class FrmAdmin
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
            this.grpMemberDB = new System.Windows.Forms.GroupBox();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername3 = new System.Windows.Forms.TextBox();
            this.txtFirstName2 = new System.Windows.Forms.TextBox();
            this.txtLastName2 = new System.Windows.Forms.TextBox();
            this.txtPIN3 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpLibraryDB = new System.Windows.Forms.GroupBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.chkAdmin3 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.grpMemberDB.SuspendLayout();
            this.grpLibraryDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMemberDB
            // 
            this.grpMemberDB.Controls.Add(this.lstMembers);
            this.grpMemberDB.Controls.Add(this.btnRemove);
            this.grpMemberDB.Controls.Add(this.txtUsername3);
            this.grpMemberDB.Controls.Add(this.txtFirstName2);
            this.grpMemberDB.Controls.Add(this.txtLastName2);
            this.grpMemberDB.Controls.Add(this.txtPIN3);
            this.grpMemberDB.Controls.Add(this.chkAdmin3);
            this.grpMemberDB.Controls.Add(this.btnAdd);
            this.grpMemberDB.Controls.Add(this.label5);
            this.grpMemberDB.Controls.Add(this.label4);
            this.grpMemberDB.Controls.Add(this.label3);
            this.grpMemberDB.Controls.Add(this.label2);
            this.grpMemberDB.Controls.Add(this.label1);
            this.grpMemberDB.Location = new System.Drawing.Point(21, 22);
            this.grpMemberDB.Name = "grpMemberDB";
            this.grpMemberDB.Size = new System.Drawing.Size(560, 243);
            this.grpMemberDB.TabIndex = 0;
            this.grpMemberDB.TabStop = false;
            this.grpMemberDB.Text = "Edit Members";
            // 
            // lstMembers
            // 
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.Location = new System.Drawing.Point(7, 20);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(278, 160);
            this.lstMembers.TabIndex = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(210, 195);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Member:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "PIN";
            // 
            // txtUsername3
            // 
            this.txtUsername3.Location = new System.Drawing.Point(396, 49);
            this.txtUsername3.Name = "txtUsername3";
            this.txtUsername3.Size = new System.Drawing.Size(142, 20);
            this.txtUsername3.TabIndex = 7;
            // 
            // txtFirstName2
            // 
            this.txtFirstName2.Location = new System.Drawing.Point(396, 80);
            this.txtFirstName2.Name = "txtFirstName2";
            this.txtFirstName2.Size = new System.Drawing.Size(142, 20);
            this.txtFirstName2.TabIndex = 8;
            // 
            // txtLastName2
            // 
            this.txtLastName2.Location = new System.Drawing.Point(396, 111);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(142, 20);
            this.txtLastName2.TabIndex = 9;
            // 
            // txtPIN3
            // 
            this.txtPIN3.Location = new System.Drawing.Point(396, 142);
            this.txtPIN3.Name = "txtPIN3";
            this.txtPIN3.Size = new System.Drawing.Size(37, 20);
            this.txtPIN3.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(462, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // grpLibraryDB
            // 
            this.grpLibraryDB.Controls.Add(this.lstBooks);
            this.grpLibraryDB.Controls.Add(this.btnRemove2);
            this.grpLibraryDB.Controls.Add(this.txtISBN);
            this.grpLibraryDB.Controls.Add(this.txtTitle);
            this.grpLibraryDB.Controls.Add(this.txtAuthor);
            this.grpLibraryDB.Controls.Add(this.txtCategory);
            this.grpLibraryDB.Controls.Add(this.btnAdd2);
            this.grpLibraryDB.Controls.Add(this.label10);
            this.grpLibraryDB.Controls.Add(this.label9);
            this.grpLibraryDB.Controls.Add(this.label8);
            this.grpLibraryDB.Controls.Add(this.label7);
            this.grpLibraryDB.Controls.Add(this.label6);
            this.grpLibraryDB.Location = new System.Drawing.Point(21, 287);
            this.grpLibraryDB.Name = "grpLibraryDB";
            this.grpLibraryDB.Size = new System.Drawing.Size(560, 255);
            this.grpLibraryDB.TabIndex = 1;
            this.grpLibraryDB.TabStop = false;
            this.grpLibraryDB.Text = "Edit Books";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Location = new System.Drawing.Point(7, 20);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(278, 173);
            this.lstBooks.TabIndex = 0;
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(209, 210);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(75, 23);
            this.btnRemove2.TabIndex = 1;
            this.btnRemove2.Text = "Remove";
            this.btnRemove2.UseVisualStyleBackColor = true;
            // 
            // chkAdmin3
            // 
            this.chkAdmin3.AutoSize = true;
            this.chkAdmin3.Location = new System.Drawing.Point(313, 199);
            this.chkAdmin3.Name = "chkAdmin3";
            this.chkAdmin3.Size = new System.Drawing.Size(86, 17);
            this.chkAdmin3.TabIndex = 13;
            this.chkAdmin3.Text = "Administrator";
            this.chkAdmin3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ISBN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Author";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Category";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(396, 53);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(142, 20);
            this.txtISBN.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(396, 85);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(142, 20);
            this.txtTitle.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(396, 117);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(142, 20);
            this.txtAuthor.TabIndex = 9;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(396, 149);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(142, 20);
            this.txtCategory.TabIndex = 10;
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(461, 210);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 11;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 565);
            this.Controls.Add(this.grpMemberDB);
            this.Controls.Add(this.grpLibraryDB);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.grpMemberDB.ResumeLayout(false);
            this.grpMemberDB.PerformLayout();
            this.grpLibraryDB.ResumeLayout(false);
            this.grpLibraryDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMemberDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPIN3;
        private System.Windows.Forms.TextBox txtLastName2;
        private System.Windows.Forms.TextBox txtFirstName2;
        private System.Windows.Forms.TextBox txtUsername3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpLibraryDB;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.CheckBox chkAdmin3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN;
    }
}