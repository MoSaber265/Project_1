using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class WelcomeForm : Form
    {
        private User currentUser;
        private List<string> itemsList = new List<string>();

        // 
        private static List<User> allUsers = new List<User>();

        // Constructor that takes a User object
        public WelcomeForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            //  
            if (!allUsers.Any(u => u.Username == user.Username && u.Email == user.Email))
            {
                allUsers.Add(user);
            }

            DisplayUserInfo();
            LoadSampleItems();
            LoadAllUsers(); // 
        }

        // Default constructor
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void DisplayUserInfo()
        {
            // Display user information in the textboxes
            if (currentUser != null)
            {
                txtUser.Text = currentUser.Username;
                txtEmail.Text = currentUser.Email;
                txtPass.Text = currentUser.Password;
            }
        }

        private void LoadSampleItems()
        {
            // Add sample items to the listbox
            if (currentUser != null)
            {
                listBox1.Items.Add($"Welcome {currentUser.Username}!");
                
            }
        }

        //  
        private void LoadAllUsers()
        {
            listBox1.Items.Add("---------------------------");
            listBox1.Items.Add("All Logged Users:");
            foreach (var user in allUsers)
            {
                listBox1.Items.Add($" {user.Username}");
            }
            listBox1.Items.Add("---------------------------");
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            // Set form title with username
            if (currentUser != null)
            {
                this.Text = $"Welcome - {currentUser.Username}";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Handle listbox selection
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle username text changes
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle email text changes
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            // Optional: Handle password text changes
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Go back to login form
            this.Hide();

            // Find existing login form or create new one
            var loginForms = Application.OpenForms.OfType<HomeForm>();
            if (loginForms.Any())
            {
                loginForms.First().Show();
            }
            else
            {
                HomeForm homeForm = new HomeForm();
                homeForm.Show();
            }
        }

        // Method to add new item to list
        public void AddItemToList(string newItem)
        {
            if (!string.IsNullOrEmpty(newItem) && currentUser != null)
            {
                string itemWithUser = $"{newItem} - Added by: {currentUser.Username}";
                listBox1.Items.Add(itemWithUser);
                itemsList.Add(itemWithUser);
            }
        }

        // Method to get all items
        public List<string> GetAllItems()
        {
            return new List<string>(itemsList);
        }

        // Method to clear the list
        public void ClearList()
        {
            listBox1.Items.Clear();
            itemsList.Clear();
        }

        // Method to update user information
        public void UpdateUserInfo(User updatedUser)
        {
            currentUser = updatedUser;
            DisplayUserInfo();
        }

        // Method to get current user
        public User GetCurrentUser()
        {
            return currentUser;
        }
    }
}
