using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questacode1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateLogin(txtUserName.Text, txtPassword.Text))
            {
                MessageBox.Show("Login successful!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateLogin(string username, string password)
        {
            // Path to the text file (store in a non-web-accessible location if possible)
            string filePath = Directory.GetCurrentDirectory() + "\\Credentials\\Credentials.txt"; ;

            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Iterate through the lines to find a matching username/password combination
                foreach (string line in lines)
                {
                    // Split each line into username and password (assuming comma-separated format)
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        string storedUsername = parts[0].Trim();
                        string storedPassword = parts[1].Trim();  

                        if (username == storedUsername && password == storedPassword) 
                        {
                            if (storedUsername.Contains("parent"))
                            {
                                Utilities.isParent = true;
                            }
                            return true; // Login successful
                        }
                    }
                    
                }
            }
            catch (FileNotFoundException)
            {
                // Handle the case where the file doesn't exist
                MessageBox.Show("Credentials file not found.  Please contact your administrator.", "Error");
                return false; 
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error reading credentials file: " + ex.Message, "Error");
                return false;
            }

            return false; // Login failed
        }
    }
}
