﻿namespace Project
{
    partial class QContent
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
            this.richTextBox_answer = new System.Windows.Forms.RichTextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_userID = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Content = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_answer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_answer
            // 
            this.richTextBox_answer.Location = new System.Drawing.Point(24, 258);
            this.richTextBox_answer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox_answer.Name = "richTextBox_answer";
            this.richTextBox_answer.Size = new System.Drawing.Size(731, 216);
            this.richTextBox_answer.TabIndex = 0;
            this.richTextBox_answer.Text = "";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Title.Location = new System.Drawing.Point(32, 24);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(49, 20);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "제목";
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.Location = new System.Drawing.Point(510, 29);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(52, 15);
            this.label_userID.TabIndex = 3;
            this.label_userID.Text = "작성자";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(623, 29);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(52, 15);
            this.label_Date.TabIndex = 4;
            this.label_Date.Text = "등록일";
            // 
            // label_Content
            // 
            this.label_Content.Location = new System.Drawing.Point(33, 85);
            this.label_Content.MaximumSize = new System.Drawing.Size(697, 138);
            this.label_Content.Name = "label_Content";
            this.label_Content.Size = new System.Drawing.Size(697, 138);
            this.label_Content.TabIndex = 6;
            this.label_Content.Text = "내용";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 2);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(24, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(731, 2);
            this.label2.TabIndex = 8;
            // 
            // button_answer
            // 
            this.button_answer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_answer.FlatAppearance.BorderSize = 0;
            this.button_answer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_answer.Location = new System.Drawing.Point(696, 482);
            this.button_answer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_answer.Name = "button_answer";
            this.button_answer.Size = new System.Drawing.Size(59, 29);
            this.button_answer.TabIndex = 46;
            this.button_answer.Text = "완료";
            this.button_answer.UseVisualStyleBackColor = false;
            // 
            // QContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 549);
            this.Controls.Add(this.button_answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Content);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_userID);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.richTextBox_answer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QContent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_answer;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_answer;
    }
}