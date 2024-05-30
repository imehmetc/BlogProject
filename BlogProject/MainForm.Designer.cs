namespace BlogProject
{
    partial class MainForm
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
            label1 = new Label();
            btnExit = new Button();
            pbImagePath = new PictureBox();
            flpPosts = new FlowLayoutPanel();
            rtxtContent = new RichTextBox();
            txtTitle = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImagePath).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(926, 427);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(60, 25);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pbImagePath
            // 
            pbImagePath.BackColor = SystemColors.AppWorkspace;
            pbImagePath.Location = new Point(10, 33);
            pbImagePath.Name = "pbImagePath";
            pbImagePath.Size = new Size(226, 216);
            pbImagePath.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagePath.TabIndex = 3;
            pbImagePath.TabStop = false;
            pbImagePath.Click += pbImagePath_Click;
            // 
            // flpPosts
            // 
            flpPosts.Location = new Point(258, 12);
            flpPosts.Name = "flpPosts";
            flpPosts.Size = new Size(728, 409);
            flpPosts.TabIndex = 4;
            // 
            // rtxtContent
            // 
            rtxtContent.Location = new Point(67, 269);
            rtxtContent.Name = "rtxtContent";
            rtxtContent.Size = new Size(169, 131);
            rtxtContent.TabIndex = 5;
            rtxtContent.Text = "";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(60, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(143, 23);
            txtTitle.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 272);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 7;
            label2.Text = "Content:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 406);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(224, 46);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 461);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(rtxtContent);
            Controls.Add(flpPosts);
            Controls.Add(pbImagePath);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)pbImagePath).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnExit;
        private PictureBox pbImagePath;
        private FlowLayoutPanel flpPosts;
        private RichTextBox rtxtContent;
        private TextBox txtTitle;
        private Label label2;
        private Button btnAdd;
    }
}