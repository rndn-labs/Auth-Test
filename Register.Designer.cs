namespace Simple_Auth_Test
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.reg_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reg_pass = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.reg_login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.reg_pass);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регистрация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // reg_login
            // 
            this.reg_login.Location = new System.Drawing.Point(50, 50);
            this.reg_login.Name = "reg_login";
            this.reg_login.Size = new System.Drawing.Size(204, 20);
            this.reg_login.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // reg_pass
            // 
            this.reg_pass.Location = new System.Drawing.Point(50, 76);
            this.reg_pass.Name = "reg_pass";
            this.reg_pass.Size = new System.Drawing.Size(204, 20);
            this.reg_pass.TabIndex = 1;
            // 
            // reg_btn
            // 
            this.reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_btn.Location = new System.Drawing.Point(12, 123);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(260, 41);
            this.reg_btn.TabIndex = 7;
            this.reg_btn.Text = "Зарегистрироваться";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ФИО";
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(50, 24);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(204, 20);
            this.fio.TabIndex = 5;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reg_btn);
            this.Name = "Register";
            this.Text = "Register";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reg_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reg_pass;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fio;
    }
}