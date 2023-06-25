using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PetsBook
{
    public partial class Form2 : Form
    {
        private readonly string connectionString = "Data Source=PetsDiary.db;Version=3;";
        private MyDatabase database;

        public Form2()
        {
            InitializeComponent();
            database = new MyDatabase();
            database.CreateDatabaseIfNotExists();
        }

      

        //public long LastInsertRowId(SQLiteCommand command)
        //{
        //    if (command == null)
        //    {
        //        throw new ArgumentNullException(nameof(command));
        //    }
        //    return (long)command.ExecuteScalar();
        //}

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // получение данных из формы
            string petName = PetNameTextBox.Text;
            string breed = BreedTextBox.Text;
            DateTime birthDate = BirthDateTimePicker.Value;
            string gender = MaleRadioButton.Checked ? "Мужской" : "Женский";
            string ownerName = OwnerNameTextBox.Text;
            string ownerSurname = OwnerSurnameTextBox.Text;
            string address = AddressTextBox.Text;
            string phone = PhoneTextBox.Text;

            byte[] photo = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    photo = ms.ToArray();
                }
            }

            // сохранение данных в базу данных
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO pets (user_id, name, breed, age, photo) " +
                                      "VALUES (@UserId, @Name, @Breed, @Age, @Photo)";
                command.Parameters.AddWithValue("@UserId", 1); // TODO: заменить на id текущего пользователя
                command.Parameters.AddWithValue("@Name", petName);
                command.Parameters.AddWithValue("@Breed", breed);
                string age = (DateTime.Now.Year - birthDate.Year).ToString() + "-" + birthDate.Month.ToString("00");
                command.Parameters.Add("@Age", System.Data.DbType.String).Value = age;
                command.Parameters.AddWithValue("@Photo", photo ?? (object)DBNull.Value);
                command.ExecuteNonQuery();

                long petId = connection.LastInsertRowId;

                command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO owners (pet_id, first_name, last_name, address, phone) " +
                                      "VALUES (@PetId, @FirstName, @LastName, @Address, @Phone)";
                command.Parameters.AddWithValue("@PetId", petId);
                command.Parameters.AddWithValue("@FirstName", ownerName);
                command.Parameters.AddWithValue("@LastName", ownerSurname);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Phone", phone);
                command.ExecuteNonQuery();

                MessageBox.Show("Данные успешно сохранены");

                // Передача id питомца в новую форму для вывода данных владельца
                OwnerForm ownerForm = new OwnerForm((int)petId);
                ownerForm.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Выберите фотографию";
            openFileDialog.Filter = "Файлы изображений (.jpg, *.jpeg, *.png)|.jpg;.jpeg;.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
    
}
