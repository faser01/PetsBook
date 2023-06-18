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
            MyDatabase database = new MyDatabase();
            database.CreateDatabaseIfNotExists();
            StartPosition = FormStartPosition.CenterScreen;
            txtPassword.PasswordChar = '●';
            txtUsername.MaxLength = 50;
            txtPassword.MaxLength = 50;
        }

       

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Пароль должен быть не менее 6 символов");
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection(@"Data Source=PetsDiary.db;Version=3;"))
                {
                    connection.Open();

                    var command = new SQLiteCommand("SELECT COUNT(*) FROM users WHERE username=@username", connection);
                    command.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Пользователь с таким именем уже существует");
                        return;
                    }

                    command = new SQLiteCommand("INSERT INTO users (username, password) VALUES (@username, @password)", connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Пользователь успешно создан");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
