using Azure.Core;
using BlogProject.Context;
using BlogProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlogProject
{
    public partial class RegisterForm : Form
    {
        private readonly AppDbContext _context;
        public RegisterForm(AppDbContext db)
        {
            InitializeComponent();
            _context = db;
            lblHataMesaj.ForeColor = Color.Red;

            txtUserName.TabIndex = 0;
            txtPassword.TabIndex = 1;
            txtConfirmPassword.TabIndex = 1;
            txtUserName.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                lblHataMesaj.Text = "UserName cannot be empty.";
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lblHataMesaj.Text = "Password cannot be empty.";
                return;
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblHataMesaj.Text = "Password Confirm cannot be empty.";
                return;
            }

            if (password != confirmPassword)
            {
                lblHataMesaj.Text = "Passwords don't match";
                return;
            }

            var existingUSer = _context.Users.Any(x => x.UserName == userName);
            if (existingUSer)
            {
                lblHataMesaj.Text = "This UserName already Exists.";
                return;
            }

            User newUser = new()
            {
                UserName = userName,
                Password = password
            };

            _context.Users.Add(newUser);
            _context.SaveChanges();

            MessageBox.Show("Registration Successfull");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
