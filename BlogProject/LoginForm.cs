using Azure.Core;
using BlogProject.Context;
using BlogProject.StaticMethods;

namespace BlogProject
{
    public partial class LoginForm : Form
    {
        private readonly AppDbContext _context;
        public LoginForm(AppDbContext db)
        {
            InitializeComponent();
            _context = db;
            lblHataMesaj.ForeColor = Color.Red;

            txtUserName.TabIndex = 0;
            txtPassword.TabIndex = 1;
            txtUserName.Focus();

            #region Veritabanında önceden yazılmış şifreleri SHA-256 şifreleme yöntemine çevir.
            //var users = _context.Users.ToList();
            //foreach (var item in users)
            //{
            //    item.Password = Sha256Hasher.ComputeSha256Hash(item.Password);
            //    _context.Users.Update(item);
            //}
            //_context.SaveChanges(); 
            #endregion
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                lblHataMesaj.Text = "Please enter UserName and Password.";
                return;
            }

            var user = _context.Users.FirstOrDefault(x => x.UserName == userName && x.Password == Sha256Hasher.ComputeSha256Hash(password));

            if (user != null)
            {
                MessageBox.Show("Login Successful");

                MainForm mainForm = new MainForm(_context, user);
                mainForm.Show();
                this.Hide();
            }
            else
                lblHataMesaj.Text = "Incorrect UserName or Password";
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_context);
            registerForm.ShowDialog();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
