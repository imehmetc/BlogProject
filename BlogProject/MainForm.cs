using BlogProject.Context;
using BlogProject.Entities;
using Microsoft.EntityFrameworkCore;
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
    public partial class MainForm : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;
        private readonly string _imageDirectory;

        public MainForm(AppDbContext db, User user)
        {
            InitializeComponent();
            _context = db;
            _user = user;

            _imageDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
            if (!Directory.Exists(_imageDirectory))
            {
                Directory.CreateDirectory(_imageDirectory);
            }

            LoadPosts();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text;
                string content = rtxtContent.Text;
                string imagePath = pbImagePath.ImageLocation;

                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Title cannot be empty");
                    return;
                }
                if (string.IsNullOrWhiteSpace(content))
                {
                    MessageBox.Show("Content cannot be empty");
                    return;
                }

                string savedImagePath = null;
                if (!string.IsNullOrEmpty(imagePath))
                {
                    string extension = Path.GetExtension(imagePath);
                    string fileName = Guid.NewGuid().ToString() + extension;
                    savedImagePath = Path.Combine(_imageDirectory, fileName);
                    File.Copy(imagePath, savedImagePath);
                }

                Post post = new Post();
                post.Title = title;
                post.Content = content;
                post.ImagePath = savedImagePath;
                post.UserId = _user.Id;
                post.CreatedDate = DateTime.Now;

                _context.Posts.Add(post);
                _context.SaveChanges();
                
                LoadPosts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void pbImagePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Resim Seç"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbImagePath.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadPosts()
        {
            flpPosts.Controls.Clear();
            flpPosts.AutoScroll = true;
            var posts = _context.Posts.Include(x => x.User).OrderByDescending(x => x.CreatedDate).ToList();
            foreach (var item in posts)
            {
                Panel panel = new Panel();
                panel.Width = 725;
                panel.Height = 54;
                panel.BorderStyle = BorderStyle.FixedSingle;

                panel.Controls.Add(new Label() { Text = "Ekleyen: " + item.User.UserName, Location = new Point(10, 10) });
                panel.Controls.Add(new Label() { Text = item.Title, Location = new Point(150, 10) });
                panel.Controls.Add(new Label() { Text = item.Content, Location = new Point(300, 10) });
                panel.Controls.Add(new PictureBox()
                {
                    ImageLocation = item.ImagePath,
                    Location = new Point(450, 10),
                    Size = new Size(50, 50),
                    SizeMode = PictureBoxSizeMode.Zoom
                });

                flpPosts.Controls.Add(panel);
            }
        }
    }
}
