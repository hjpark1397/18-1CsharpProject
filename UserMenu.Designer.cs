namespace FinalProjectPOS
{
    partial class UserMenu
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
            this.components = new System.ComponentModel.Container();
            this.Logout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5_Pay = new System.Windows.Forms.TextBox();
            this.textBox4_WorkingTime = new System.Windows.Forms.TextBox();
            this.textBox3_Phone = new System.Windows.Forms.TextBox();
            this.textBox2_BirthDay = new System.Windows.Forms.TextBox();
            this.textBox1_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.label7_TotalPay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("BM DoHyeon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Logout.Location = new System.Drawing.Point(232, 573);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(91, 36);
            this.Logout.TabIndex = 5;
            this.Logout.Text = "로그아웃";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn,
            this.paymentDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.totalpayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(408, 280);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 6;
            // 
            // AddEmployee
            // 
            this.AddEmployee.BackColor = System.Drawing.SystemColors.MenuBar;
            this.AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee.Font = new System.Drawing.Font("BM DoHyeon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AddEmployee.Location = new System.Drawing.Point(307, 59);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(113, 45);
            this.AddEmployee.TabIndex = 8;
            this.AddEmployee.Text = "직원 추가";
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // End
            // 
            this.End.BackColor = System.Drawing.SystemColors.MenuBar;
            this.End.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.End.Font = new System.Drawing.Font("BM DoHyeon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.End.Location = new System.Drawing.Point(329, 573);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(91, 36);
            this.End.TabIndex = 5;
            this.End.Text = "종료하기";
            this.End.UseVisualStyleBackColor = false;
            this.End.Click += new System.EventHandler(this.End_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5_Pay);
            this.groupBox1.Controls.Add(this.textBox4_WorkingTime);
            this.groupBox1.Controls.Add(this.textBox3_Phone);
            this.groupBox1.Controls.Add(this.textBox2_BirthDay);
            this.groupBox1.Controls.Add(this.textBox1_Name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("BM DoHyeon", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 192);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "직원 정보";
            // 
            // textBox5_Pay
            // 
            this.textBox5_Pay.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5_Pay.Location = new System.Drawing.Point(139, 158);
            this.textBox5_Pay.Name = "textBox5_Pay";
            this.textBox5_Pay.Size = new System.Drawing.Size(125, 26);
            this.textBox5_Pay.TabIndex = 1;
            // 
            // textBox4_WorkingTime
            // 
            this.textBox4_WorkingTime.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4_WorkingTime.Location = new System.Drawing.Point(139, 128);
            this.textBox4_WorkingTime.Name = "textBox4_WorkingTime";
            this.textBox4_WorkingTime.Size = new System.Drawing.Size(125, 26);
            this.textBox4_WorkingTime.TabIndex = 1;
            // 
            // textBox3_Phone
            // 
            this.textBox3_Phone.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3_Phone.Location = new System.Drawing.Point(139, 97);
            this.textBox3_Phone.Name = "textBox3_Phone";
            this.textBox3_Phone.Size = new System.Drawing.Size(125, 26);
            this.textBox3_Phone.TabIndex = 1;
            // 
            // textBox2_BirthDay
            // 
            this.textBox2_BirthDay.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2_BirthDay.Location = new System.Drawing.Point(139, 65);
            this.textBox2_BirthDay.Name = "textBox2_BirthDay";
            this.textBox2_BirthDay.Size = new System.Drawing.Size(125, 26);
            this.textBox2_BirthDay.TabIndex = 1;
            // 
            // textBox1_Name
            // 
            this.textBox1_Name.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1_Name.Location = new System.Drawing.Point(139, 31);
            this.textBox1_Name.Name = "textBox1_Name";
            this.textBox1_Name.Size = new System.Drawing.Size(125, 26);
            this.textBox1_Name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "시급";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "일한시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "전화번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "생년월일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("BM DoHyeon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delete.Location = new System.Drawing.Point(307, 110);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(113, 44);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "정보 삭제";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change.Font = new System.Drawing.Font("BM DoHyeon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Change.Location = new System.Drawing.Point(307, 160);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(113, 44);
            this.Change.TabIndex = 8;
            this.Change.Text = "정보 수정";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // label7_TotalPay
            // 
            this.label7_TotalPay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label7_TotalPay.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7_TotalPay.Location = new System.Drawing.Point(149, 220);
            this.label7_TotalPay.Name = "label7_TotalPay";
            this.label7_TotalPay.Size = new System.Drawing.Size(127, 26);
            this.label7_TotalPay.TabIndex = 12;
            this.label7_TotalPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7_TotalPay.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(18, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "▶ 총 임금";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDayDataGridViewTextBoxColumn
            // 
            this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.HeaderText = "BirthDay";
            this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
            this.birthDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            this.phoneNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDataGridViewTextBoxColumn
            // 
            this.paymentDataGridViewTextBoxColumn.DataPropertyName = "Payment";
            this.paymentDataGridViewTextBoxColumn.HeaderText = "Payment";
            this.paymentDataGridViewTextBoxColumn.Name = "paymentDataGridViewTextBoxColumn";
            this.paymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalpayDataGridViewTextBoxColumn
            // 
            this.totalpayDataGridViewTextBoxColumn.DataPropertyName = "Totalpay";
            this.totalpayDataGridViewTextBoxColumn.HeaderText = "Totalpay";
            this.totalpayDataGridViewTextBoxColumn.Name = "totalpayDataGridViewTextBoxColumn";
            this.totalpayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(FinalProjectPOS.Person);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(432, 616);
            this.Controls.Add(this.label7_TotalPay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Logout);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button End;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5_Pay;
        private System.Windows.Forms.TextBox textBox4_WorkingTime;
        private System.Windows.Forms.TextBox textBox3_Phone;
        private System.Windows.Forms.TextBox textBox2_BirthDay;
        private System.Windows.Forms.TextBox textBox1_Name;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Label label7_TotalPay;
        private System.Windows.Forms.Label label8;
    }
}