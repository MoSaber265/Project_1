namespace LoginApp
{
    partial class WelcomeForm
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
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            txtUser = new TextBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Desktop;
            btnBack.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(555, 392);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(237, 75);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(588, 20);
            label1.Name = "label1";
            label1.Size = new Size(185, 54);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 96);
            label2.Name = "label2";
            label2.Size = new Size(78, 41);
            label2.TabIndex = 2;
            label2.Text = "User";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(120, 158);
            label3.Name = "label3";
            label3.Size = new Size(88, 41);
            label3.TabIndex = 3;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(65, 231);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(143, 41);
            label4.TabIndex = 4;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(971, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(359, 411);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(226, 96);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(529, 47);
            txtUser.TabIndex = 6;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(226, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(529, 47);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(224, 231);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(531, 47);
            txtPass.TabIndex = 6;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1380, 628);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtUser);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private TextBox txtUser;
        private TextBox txtEmail;
        private TextBox txtPass;
    }
}