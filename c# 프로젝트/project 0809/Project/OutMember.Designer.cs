namespace Project
{
    partial class OutMember
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
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label_Out = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_search = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(554, 39);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(114, 25);
            this.textBox_search.TabIndex = 23;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(464, 39);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(83, 23);
            this.comboBox.TabIndex = 22;
            // 
            // label_Out
            // 
            this.label_Out.AutoSize = true;
            this.label_Out.Location = new System.Drawing.Point(11, 44);
            this.label_Out.Name = "label_Out";
            this.label_Out.Size = new System.Drawing.Size(97, 15);
            this.label_Out.TabIndex = 21;
            this.label_Out.Text = "탈퇴 멤버 수 ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 438);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "탈퇴 멤버 조회";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(721, 346);
            this.dataGridView1.TabIndex = 19;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(136, 42);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(0, 15);
            this.label_search.TabIndex = 25;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Location = new System.Drawing.Point(675, 39);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(59, 29);
            this.button_search.TabIndex = 26;
            this.button_search.Text = "검색";
            this.button_search.UseVisualStyleBackColor = false;
            // 
            // OutMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label_Out);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OutMember";
            this.Text = "탈퇴 회원 수";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label_Out;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button button_search;
    }
}