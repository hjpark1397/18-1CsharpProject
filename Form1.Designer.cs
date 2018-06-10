namespace FinalProjectPOS
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
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.PW_txt = new System.Windows.Forms.TextBox();
            this.LOGIN = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.PW = new System.Windows.Forms.Label();
            this.Join = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_txt
            // 
            this.ID_txt.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_txt.Location = new System.Drawing.Point(133, 134);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(128, 26);
            this.ID_txt.TabIndex = 0;
            // 
            // PW_txt
            // 
            this.PW_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PW_txt.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PW_txt.Location = new System.Drawing.Point(133, 173);
            this.PW_txt.Name = "PW_txt";
            this.PW_txt.Size = new System.Drawing.Size(128, 26);
            this.PW_txt.TabIndex = 1;
            this.PW_txt.UseSystemPasswordChar = true;
            // 
            // LOGIN
            // 
            this.LOGIN.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGIN.Font = new System.Drawing.Font("BM DoHyeon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LOGIN.Location = new System.Drawing.Point(281, 134);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(74, 65);
            this.LOGIN.TabIndex = 2;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = false;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.SystemColors.MenuBar;
            this.EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EXIT.Font = new System.Drawing.Font("BM DoHyeon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EXIT.Location = new System.Drawing.Point(215, 230);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(97, 25);
            this.EXIT.TabIndex = 3;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID.Location = new System.Drawing.Point(44, 138);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(59, 16);
            this.ID.TabIndex = 4;
            this.ID.Text = "아이디";
            // 
            // PW
            // 
            this.PW.AutoSize = true;
            this.PW.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PW.Location = new System.Drawing.Point(44, 176);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(76, 16);
            this.PW.TabIndex = 5;
            this.PW.Text = "비밀번호";
            // 
            // Join
            // 
            this.Join.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Join.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Join.Font = new System.Drawing.Font("BM DoHyeon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Join.Location = new System.Drawing.Point(80, 230);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(98, 25);
            this.Join.TabIndex = 6;
            this.Join.Text = "회원가입";
            this.Join.UseVisualStyleBackColor = false;
            this.Join.Click += new System.EventHandler(this.Join_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BernhardFashion BT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 42);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 65);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(333, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(283, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(233, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.Location = new System.Drawing.Point(183, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 41);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(393, 282);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Join);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.PW_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox PW_txt;
        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label PW;
        private System.Windows.Forms.Button Join;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

