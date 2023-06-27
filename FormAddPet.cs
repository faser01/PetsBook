using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsBook
{
    public partial class FormAddPet : Form
    {
        private MyDatabase db = new MyDatabase();
        private readonly SQLiteConnection _connection;
        private readonly int _userId;
        private readonly List<Pet> _pets;

        public FormAddPet(List<Pet> pets, SQLiteConnection connection, int userId)
        {
            InitializeComponent();
            db = new MyDatabase();
            db.CreateDatabaseIfNotExists();
            _pets = pets;
            _connection = connection;
            
            _userId = userId;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Проверяем, что все поля заполнены
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxBreed.Text) ||
                string.IsNullOrEmpty(textBoxAge.Text) || pictureBoxPhoto.Image == null)
            {
                MessageBox.Show("Заполните все поля и выберите фото!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверяем правильность ввода возраста
            if (!int.TryParse(textBoxAge.Text, out int age))
            {
                MessageBox.Show("Некорректный возраст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создаем новый объект питомца и добавляем его в список
            var newPet = new Pet(textBoxName.Text, textBoxBreed.Text, age, pictureBoxPhoto.Image);
            _pets.Add(newPet);

            // Создаем новую запись в таблице домашних животных
            string insertPetQuery = "INSERT INTO pets (user_id, name, breed, age, photo) VALUES (@userId, @name, @breed, @age, @photo);";
            using (var insertPetCommand = new SQLiteCommand(insertPetQuery, db.connection))
            {
                insertPetCommand.Parameters.AddWithValue("@userId", _userId);
                insertPetCommand.Parameters.AddWithValue("@name", textBoxName.Text);
                insertPetCommand.Parameters.AddWithValue("@breed", textBoxBreed.Text);
                insertPetCommand.Parameters.AddWithValue("@age", textBoxAge.Text);
                if (pictureBoxPhoto.Image != null)
                {
                    insertPetCommand.Parameters.AddWithValue("@photo", ImageToByteArray(pictureBoxPhoto.Image));
                }

                insertPetCommand.ExecuteNonQuery();
            }

            // Закрываем форму
            Close();
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                return memoryStream.ToArray();
            }
        }

       

        private void buttonSelectPhoto_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.gif,*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
