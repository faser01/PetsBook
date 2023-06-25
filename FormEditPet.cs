using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsBook
{
    public partial class FormEditPet : Form
    {
        private readonly string connectionString = "Data Source=PetsDiary.db;Version=3;";
        private readonly Pet pet;
        private readonly Owner owner;

        public FormEditPet(Pet pet, Owner owner)
        {
            InitializeComponent();
            this.pet = pet;
            this.owner = owner;

            // Заполняем поля формы текущими данными
            textBoxPetName.Text = pet.Name;
            textBoxPetBreed.Text = pet.Breed;
            textBoxPetAge.Text = pet.Age.ToString();
            pictureBoxPetPhoto.Image = pet.Photo;

            if (owner != null)
            {
                textBoxOwnerFirstName.Text = owner.FirstName;
                textBoxOwnerLastName.Text = owner.LastName;
                textBoxOwnerAddress.Text = owner.Address;
                textBoxOwnerPhone.Text = owner.Phone;
            }
        }

        private void ExecuteQuery(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }


        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            // Обновляем объект питомца новыми данными
            pet.Name = textBoxPetName.Text;
            pet.Breed = textBoxPetBreed.Text;
            pet.Age = int.Parse(textBoxPetAge.Text);
            pet.Photo = pictureBoxPetPhoto.Image;

            if (owner != null)
            {
                // Обновляем объект-владелец новыми данными
                owner.FirstName = textBoxOwnerFirstName.Text;
                owner.LastName = textBoxOwnerLastName.Text;
                owner.Address = textBoxOwnerAddress.Text;
                owner.Phone = textBoxOwnerPhone.Text;

                // Обновляем запись в таблице "owners"
                string updateOwnerQuery = $"UPDATE owners SET first_name='{owner.FirstName}', last_name='{owner.LastName}', address='{owner.Address}', phone='{owner.Phone}' WHERE pet_id={pet.Id};";
                ExecuteQuery(updateOwnerQuery);
            }
            else
            {
                // Создаем новый объект-владелец с новыми данными и добавляем его в список владельцев
                Owner newOwner = new Owner(textBoxOwnerFirstName.Text, textBoxOwnerLastName.Text, textBoxOwnerAddress.Text, textBoxOwnerPhone.Text, pet.Id);
                PetsDatabase.Owners.Add(newOwner);

                // Добавляем новую запись в таблицу "owners"
                string insertOwnerQuery = $"INSERT INTO owners (pet_id, first_name, last_name, address, phone) VALUES ({pet.Id}, '{newOwner.FirstName}', '{newOwner.LastName}', '{newOwner.Address}', '{newOwner.Phone}');";
                ExecuteQuery(insertOwnerQuery);
            }

            // Обновляем запись в таблице "pets"
            string updatePetQuery = $"UPDATE pets SET name='{pet.Name}', breed='{pet.Breed}', age='{pet.Age}', photo=@photo WHERE id={pet.Id};";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(updatePetQuery, connection))
                {
                    command.Parameters.AddWithValue("@photo", ImageToByteArray(pet.Photo));
                    command.ExecuteNonQuery();
                }
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
