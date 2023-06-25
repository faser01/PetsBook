using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        private readonly SQLiteConnection _connection;
        private readonly int userId;
        private readonly List<Pet> pets;

        public FormAddPet(List<Pet> pets, SQLiteConnection connection, int userId)
        {
            InitializeComponent();
            this.pets = pets;
            _connection = connection;
            this.userId = userId;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {// Проверяем, что все поля заполнены
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
            pets.Add(newPet);

            // Создаем новую запись в таблице домашних животных
            string insertPetQuery = "INSERT INTO pets (user_id, name, breed, age, photo) VALUES (@userId, @name, @breed, @age, @photo);";
            using (var insertPetCommand = new SQLiteCommand())
            {
                insertPetCommand.Connection = _connection;
                insertPetCommand.CommandText = insertPetQuery;
                insertPetCommand.Parameters.AddWithValue("@userId", userId);
                insertPetCommand.Parameters.AddWithValue("@name", textBoxName.Text);
                insertPetCommand.Parameters.AddWithValue("@breed", textBoxBreed.Text);
                insertPetCommand.Parameters.AddWithValue("@age", textBoxAge.Text);
                if (pictureBoxPhoto.Image != null)
                {
                    insertPetCommand.Parameters.AddWithValue("@photo", ImageToByteArray(pictureBoxPhoto.Image));
                }
                else
                {
                    insertPetCommand.Parameters.AddWithValue("@photo", DBNull.Value);
                }
                insertPetCommand.ExecuteNonQuery();
            }

            MessageBox.Show("Питомец успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonSelectPhoto_Click(object sender, EventArgs e)
        {


            // Открыть диалоговое окно файла для выбора фотографии
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
