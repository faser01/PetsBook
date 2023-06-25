﻿using System;
using System.Data.SQLite;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetsBook
{

    public class MyDatabase
    {
        private SQLiteConnection _connection;
  
        public string connectionString = "Data Source=PetsDiary.db;Version=3;";
        public void CreateDatabaseIfNotExists()
        {// проверка на null
            if (_connection == null)
            {
                _connection = new SQLiteConnection(connectionString);
                _connection.Open();
            }

            SQLiteCommand command = new SQLiteCommand(_connection);

            string createUserTableQuery = @"CREATE TABLE IF NOT EXISTS users (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        login TEXT NOT NULL UNIQUE,
                        password TEXT NOT NULL
                    );";
            SQLiteCommand createUserTableCommand = new SQLiteCommand(createUserTableQuery, _connection);
            createUserTableCommand.ExecuteNonQuery();


            // Создание таблицы питомцев
            string createPetTableQuery = @"CREATE TABLE IF NOT EXISTS pets (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_id INTEGER NOT NULL,
                    name TEXT NOT NULL,
                    breed TEXT NOT NULL,
                    age TEXT NOT NULL,
                    photo BLOB,
                    FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
                );";
            SQLiteCommand createPetTableCommand = new SQLiteCommand(createPetTableQuery, _connection);
            createPetTableCommand.ExecuteNonQuery();

            string createOwnersTableQuery = @"CREATE TABLE IF NOT EXISTS owners (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    pet_id INTEGER NOT NULL,
                    first_name TEXT NOT NULL,
                    last_name TEXT NOT NULL,
                    address TEXT NOT NULL,
                    phone TEXT NOT NULL,
                    FOREIGN KEY (pet_id) REFERENCES pets(id) ON DELETE CASCADE
                );";
            SQLiteCommand createOwnersTableCommand = new SQLiteCommand(createOwnersTableQuery, _connection);
            createOwnersTableCommand.ExecuteNonQuery();


            // Создание таблицы уведомлений
            string createNotificationTableQuery = @"CREATE TABLE IF NOT EXISTS notifications (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                pet_id INTEGER NOT NULL,
                type TEXT NOT NULL,
                datetime TEXT NOT NULL,
                is_done INTEGER NOT NULL DEFAULT 0,
                FOREIGN KEY (pet_id) REFERENCES pets(id) ON DELETE CASCADE
            );";
            SQLiteCommand createNotificationTableCommand = new SQLiteCommand(createNotificationTableQuery, _connection);
            createNotificationTableCommand.ExecuteNonQuery();
        }
          
    }
    
}
