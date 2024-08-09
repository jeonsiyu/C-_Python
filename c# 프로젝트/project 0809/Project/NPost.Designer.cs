namespace Project
{
    partial class NPost
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
            this.richTextBox_Content = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Title = new System.Windows.Forms.RichTextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Content = new System.Windows.Forms.Label();
            this.button_post = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_Content
            // 
            this.richTextBox_Content.Location = new System.Drawing.Point(23, 69);
            this.richTextBox_Content.Name = "richTextBox_Content";
            this.richTextBox_Content.Size = new System.Drawing.Size(377, 66);
            this.richTextBox_Content.TabIndex = 0;
            this.richTextBox_Content.Text = "";
            // 
            // richTextBox_Title
            // 
            this.richTextBox_Title.Location = new System.Drawing.Point(23, 178);
            this.richTextBox_Title.Name = "richTextBox_Title";
            this.richTextBox_Title.Size = new System.Drawing.Size(588, 118);
            this.richTextBox_Title.TabIndex = 1;
            this.richTextBox_Title.Text = "";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(21, 43);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(29, 12);
            this.label_Title.TabIndex = 4;
            this.label_Title.Text = "제목";
            // 
            // label_Content
            // 
            this.label_Content.AutoSize = true;
            this.label_Content.Location = new System.Drawing.Point(21, 152);
            this.label_Content.Name = "label_Content";
            this.label_Content.Size = new System.Drawing.Size(29, 12);
            this.label_Content.TabIndex = 5;
            this.label_Content.Text = "내용";
            // 
            // button_post
            // 
            this.button_post.Location = new System.Drawing.Point(536, 307);
            this.button_post.Name = "button_post";
            this.button_post.Size = new System.Drawing.Size(75, 23);
            this.button_post.TabIndex = 6;
            this.button_post.Text = "등록";
            this.button_post.UseVisualStyleBackColor = true;
            this.button_post.Click += new System.EventHandler(this.button_post_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "관리자 : ";
            // 
            // NPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_post);
            this.Controls.Add(this.label_Content);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.richTextBox_Title);
            this.Controls.Add(this.richTextBox_Content);
            this.Name = "NPost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Content;
        private System.Windows.Forms.RichTextBox richTextBox_Title;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Content;
        private System.Windows.Forms.Button button_post;
        private System.Windows.Forms.Label label1;
    }
}