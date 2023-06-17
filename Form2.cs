﻿using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace PetsBook
{
    public partial class Form2 : Form
    {
        private readonly string connectionString = "Data Source=PetsDiary.db;Version=3;";

        public Form2()
        {
            InitializeComponent();
            MyDatabase database = new MyDatabase();
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
            // TODO: добавление фото питомца

            // сохранение данных в базу данных
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "INSERT INTO Pets (Name, Breed, DateOfBirth, Gender) " +
                                      "VALUES (@Name, @Breed, @DateOfBirth, @Gender)";
                command.Parameters.AddWithValue("@Name", petName);
                command.Parameters.AddWithValue("@Breed", breed);
                command.Parameters.AddWithValue("@DateOfBirth", birthDate);
                command.Parameters.AddWithValue("@Gender", gender);
                command.ExecuteNonQuery();

                // получение id добавленной записи
               // long petId = LastInsertRowId(command);
                command = new SQLiteCommand(connection)
                {
                    CommandText = "INSERT INTO Owners (FirstName, LastName, Address, Phone) " +
                                      "VALUES (@FirstName, @LastName, @Address, @Phone)"
                };
                command.Parameters.AddWithValue("@FirstName", ownerName);
                command.Parameters.AddWithValue("@LastName", ownerSurname);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Phone", phone);
                command.ExecuteNonQuery();

               // // получение id добавленной записи
               //// long ownerId = LastInsertRowId(command);
               // command = new SQLiteCommand(connection)
               // {
               //     CommandText = "INSERT INTO PetOwners (PetId, OwnerId) " +
               //                       "VALUES (@PetId, @OwnerId)"
               // };
               // command.Parameters.AddWithValue("@PetId", petId);
               // command.Parameters.AddWithValue("@OwnerId", ownerId);
               // command.ExecuteNonQuery();

                connection.Close();
            }

            MessageBox.Show("Данные успешно сохранены");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Установка фонового цвета кнопки
            SaveButton.BackColor = Color.FromArgb(255, 128, 0);

            // Установка цвета текста кнопки
            SaveButton.ForeColor = Color.White;

            // Установка шрифта текста кнопки
            SaveButton.Font = new Font("Arial", 12, FontStyle.Bold);

            // Установка изображения на кнопке
            SaveButton.Image = Properties.Resources.save_icon;

            // Установка выравнивания изображения и текста на кнопке
            SaveButton.ImageAlign = ContentAlignment.MiddleLeft;
            SaveButton.TextAlign = ContentAlignment.MiddleRight;
        }
    }
    
}
