namespace BlogProject
{
    partial class LoginForm
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
            txtUserName = new TextBox();
            btnLogin = new Button();
            lblRegister = new LinkLabel();
            label2 = new Label();
            txtPassword = new TextBox();
            lblHataMesaj = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(151, 51);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtUserName.Location = new Point(151, 85);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(196, 25);
            txtUserName.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(181, 228);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 41);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI", 11F);
            lblRegister.Location = new Point(160, 291);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(189, 20);
            lblRegister.TabIndex = 3;
            lblRegister.TabStop = true;
            lblRegister.Text = "Kayıtlı değilseniz kayıt olun";
            lblRegister.LinkClicked += lblRegister_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(151, 121);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtPassword.Location = new Point(151, 155);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(196, 25);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblHataMesaj
            // 
            lblHataMesaj.BorderStyle = BorderStyle.FixedSingle;
            lblHataMesaj.Location = new Point(151, 195);
            lblHataMesaj.Name = "lblHataMesaj";
            lblHataMesaj.Size = new Size(196, 20);
            lblHataMesaj.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(387, 307);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(76, 33);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 352);
            Controls.Add(btnExit);
            Controls.Add(lblHataMesaj);
            Controls.Add(lblRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private Button btnLogin;
        private LinkLabel lblRegister;
        private Label label2;
        private TextBox txtPassword;
        private Label lblHataMesaj;
        private Button btnExit;
    }
}
