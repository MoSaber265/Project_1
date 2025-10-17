using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace LoginApp
{
    partial class HomeForm : Form
    {
        private Label labelEmail;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnAddUser;
        private Button btnReset;
        private List<User> users = new List<User>();

        public HomeForm()
        {
            InitializeComponent();
            // لا نضيف أي مستخدمين هنا - يضيفهم المستخدم بنفسه
        }

        private void InitializeComponent()
        {
            labelUsername = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnAddUser = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(107, 74);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(147, 38);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "UserName";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(107, 164);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(83, 38);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(107, 248);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(132, 38);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(280, 85);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(452, 43);
            txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(280, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(452, 43);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(280, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(452, 43);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(1047, 74);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(256, 81);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUser.Location = new Point(1047, 205);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(256, 81);
            btnAddUser.TabIndex = 2;
            btnAddUser.Text = "ADD";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(1047, 333);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(256, 81);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1452, 653);
            Controls.Add(btnReset);
            Controls.Add(btnAddUser);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(labelUsername);
            Name = "HomeForm";
            Text = "Login System";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User foundUser = users.Find(u => u.Username == username && u.Email == email && u.Password == password);

            if (foundUser != null)
            {
                MessageBox.Show($"Welcome {username}!", "Login Successful",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                WelcomeForm welcomeForm = new WelcomeForm(foundUser);
                welcomeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username, email or password!", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields to add user!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (users.Exists(u => u.Username == username || u.Email == email))
            {
                MessageBox.Show("Username or email already exists!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User newUser = new User(username, email, password);
            users.Add(newUser);

            MessageBox.Show($"User {username} added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnReset_Click(sender, e);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}