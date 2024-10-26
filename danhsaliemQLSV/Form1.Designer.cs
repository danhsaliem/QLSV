namespace danhsaliemQLSV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            email = new Label();
            password = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 19);
            label1.Name = "label1";
            label1.Size = new Size(204, 45);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(73, 94);
            email.Name = "email";
            email.Size = new Size(70, 20);
            email.TabIndex = 1;
            email.Text = "tài khoản";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(73, 203);
            password.Name = "password";
            password.Size = new Size(70, 20);
            password.TabIndex = 2;
            password.Text = "mật khẩu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(477, 27);
            textBox1.TabIndex = 3;
            textBox1.UseSystemPasswordChar = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(474, 27);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(338, 271);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label email;
        private Label password;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
