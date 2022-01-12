namespace retryTodo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add_Btn = new System.Windows.Forms.Button();
            this.del_Btn = new System.Windows.Forms.Button();
            this.todoTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(253, 304);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.del_Btn);
            this.groupBox1.Controls.Add(this.add_Btn);
            this.groupBox1.Location = new System.Drawing.Point(26, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // add_Btn
            // 
            this.add_Btn.Location = new System.Drawing.Point(17, 37);
            this.add_Btn.Name = "add_Btn";
            this.add_Btn.Size = new System.Drawing.Size(75, 23);
            this.add_Btn.TabIndex = 0;
            this.add_Btn.Text = "추 가";
            this.add_Btn.UseVisualStyleBackColor = true;
            this.add_Btn.Click += new System.EventHandler(this.add_Btn_Click);
            // 
            // del_Btn
            // 
            this.del_Btn.Location = new System.Drawing.Point(98, 37);
            this.del_Btn.Name = "del_Btn";
            this.del_Btn.Size = new System.Drawing.Size(75, 23);
            this.del_Btn.TabIndex = 1;
            this.del_Btn.Text = "삭 제";
            this.del_Btn.UseVisualStyleBackColor = true;
            this.del_Btn.Click += new System.EventHandler(this.del_Btn_Click);
            // 
            // todoTxtBox
            // 
            this.todoTxtBox.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.todoTxtBox.Location = new System.Drawing.Point(26, 318);
            this.todoTxtBox.Name = "todoTxtBox";
            this.todoTxtBox.Size = new System.Drawing.Size(200, 32);
            this.todoTxtBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 450);
            this.Controls.Add(this.todoTxtBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button del_Btn;
        private System.Windows.Forms.Button add_Btn;
        private System.Windows.Forms.TextBox todoTxtBox;
    }
}

