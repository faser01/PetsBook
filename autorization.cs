
using System;
using System.Collections.Generic;
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
        private MyDatabase database;

        public autorization()
        {
            InitializeComponent();
            database = new MyDatabase();
            database.CreateDatabaseIfNotExists();
            StartPosition = FormStartPosition.CenterScreen;
            txtPassword.PasswordChar = '●';
            txtUsername.MaxLength = 50;
            txtPassword.MaxLength = 50;
        }



      
        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(inputUsername) || string.IsNullOrWhiteSpace(inputPassword))
            {
                MessageBox.Show("Пожалуйста введите свой логин и пароль.");
                return;
            }

            if (inputPassword.Length < 6)
            {
                MessageBox.Show("Пароль должен быть не менее 6 символов.");
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection(database.connectionString))
                {
                    await connection.OpenAsync();

                    var command = new SQLiteCommand("SELECT COUNT(*) FROM users WHERE login=@login", connection);
                    command.Parameters.AddWithValue("@login", inputUsername);

                    int count = Convert.ToInt32(await command.ExecuteScalarAsync());
                    if (count > 0)
                    {
                        MessageBox.Show("Пользователь с таким именем уже существует.");
                        return;
                    }

                    command = new SQLiteCommand("INSERT INTO users (login, password) VALUES (@login, @password)", connection);
                    command.Parameters.AddWithValue("@login", inputUsername);
                    command.Parameters.AddWithValue("@password", inputPassword);

                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Не удалось добавить пользователя в базу данных.");
                        return;
                    }

                    MessageBox.Show($"Пользователь {inputUsername} успешно зарегистрирован.");
                    this.Hide();
                    int userId = 0;
                    Form3 form3 = new Form3(new List<Pet>(), new List<Owner>(), new List<Notifications>(), database.connection, userId);
                    form3.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}