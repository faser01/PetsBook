using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsBook
{
    public partial class autorization : Form
    {
        public autorization()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password should be at least 6 characters long");
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PetDiary.db;Version=3;"))
                {
                    connection.Open();

                    var command = new SQLiteCommand("SELECT COUNT(*) FROM users WHERE username=@username", connection);
                    command.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("User with this username already exists");
                        return;
                    }

                    command = new SQLiteCommand("INSERT INTO users (username, password) VALUES (@username, @password)", connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    command.ExecuteNonQuery();

                    MessageBox.Show("User created successfully");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
