namespace BlogProject
{
    partial class RegisterForm
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
            btnRegister = new Button();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            lblHataMesaj = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(167, 332);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(131, 41);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtPassword.Location = new Point(138, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(196, 25);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(138, 146);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtUserName.Location = new Point(138, 110);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(196, 25);
            txtUserName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(138, 76);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(138, 222);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 4;
            label3.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtConfirmPassword.Location = new Point(138, 256);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(196, 25);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblHataMesaj
            // 
            lblHataMesaj.BorderStyle = BorderStyle.FixedSingle;
            lblHataMesaj.Location = new Point(138, 295);
            lblHataMesaj.Name = "lblHataMesaj";
            lblHataMesaj.Size = new Size(196, 15);
            lblHataMesaj.TabIndex = 9;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(387, 367);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(76, 33);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 412);
            Controls.Add(btnExit);
            Controls.Add(lblHataMesaj);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lblRegister;
        private Button btnRegister;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUserName;
        private Label label1;
        private Label label3;
        private TextBox txtConfirmPassword;
        private Label lblHataMesaj;
        private Button btnExit;
    }
}