﻿namespace Project
{
    partial class NContent
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
            this.button_delect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Content = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_userID = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_delect
            // 
            this.button_delect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_delect.FlatAppearance.BorderSize = 0;
            this.button_delect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delect.Location = new System.Drawing.Point(612, 270);
            this.button_delect.Name = "button_delect";
            this.button_delect.Size = new System.Drawing.Size(52, 23);
            this.button_delect.TabIndex = 54;
            this.button_delect.Text = "삭제";
            this.button_delect.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(24, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 2);
            this.label2.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 2);
            this.label1.TabIndex = 52;
            // 
            // label_Content
            // 
            this.label_Content.Location = new System.Drawing.Point(32, 72);
            this.label_Content.MaximumSize = new System.Drawing.Size(610, 110);
            this.label_Content.Name = "label_Content";
            this.label_Content.Size = new System.Drawing.Size(610, 110);
            this.label_Content.TabIndex = 51;
            this.label_Content.Text = "내용";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(549, 27);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(41, 12);
            this.label_Date.TabIndex = 50;
            this.label_Date.Text = "등록일";
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.Location = new System.Drawing.Point(450, 27);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(41, 12);
            this.label_userID.TabIndex = 49;
            this.label_userID.Text = "작성자";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Title.Location = new System.Drawing.Point(32, 23);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(39, 16);
            this.label_Title.TabIndex = 48;
            this.label_Title.Text = "제목";
            // 
            // NContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 315);
            this.Controls.Add(this.button_delect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Content);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_userID);
            this.Controls.Add(this.label_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NContent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_delect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Content;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.Label label_Title;
    }
}