using System;
using System.Data.SQLite;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PetsBook
{

    public class MyDatabase
    {
        private SQLiteConnection _connection;
        readonly string connectionString = "Data Source=PetsDiary.db;Version=3;";
        public void CreateDatabaseIfNotExists()
        {// проверка на null
            if (_connection == null)
            {
                _connection = new SQLiteConnection(connectionString);
                _connection.Open();
            }

            SQLiteCommand command = new SQLiteCommand(_connection);

            // создание таблицы Pets
            command.CommandText = "CREATE TABLE IF NOT EXISTS Pets " +
                "(Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "Name TEXT NOT NULL, " +
                "Breed TEXT NOT NULL, " +
                "DateOfBirth DATETIME NOT NULL, " +
                "Gender TEXT NOT NULL, " +
                "OwnerId INTEGER NOT NULL, " +
                "FOREIGN KEY(OwnerId) REFERENCES Owners(Id))";
            command.ExecuteNonQuery();

            // создание таблицы расписания
            command.CommandText = "CREATE TABLE IF NOT EXISTS Schedule(" +
                  "Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                  "Type NVARCHAR(50) NOT NULL," +
                  "DateAndTime DATETIME NOT NULL," +
                  "PetId INT NOT NULL," +
                  "FOREIGN KEY(PetId) REFERENCES Pets(Id))";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS PetPhotos (" +
                 "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                 "PetID INTEGER NOT NULL," +
                 "Photo BLOB NOT NULL," +
                 "FOREIGN KEY (PetID) REFERENCES Pets(ID))";
            command.ExecuteNonQuery();

            // создание таблицы Owners
            command.CommandText = "CREATE TABLE IF NOT EXISTS Owners " +
                "(Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "FirstName TEXT NOT NULL, " +
                "LastName TEXT NOT NULL, " +
                "Address TEXT NOT NULL, " +
                "Phone TEXT NOT NULL)";
            command.ExecuteNonQuery();

            command.CommandText = "CREATE TABLE IF NOT EXISTS users(  " +
                "id INTEGER PRIMARY KEY,  " +
                "username TEXT NOT NULL UNIQUE,  " +
                "password TEXT NOT NULL)";
            command.ExecuteNonQuery();


            // создание таблицы PetOwners
            command.CommandText = "CREATE TABLE IF NOT EXISTS PetOwners " +
                "(Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "PetId INTEGER NOT NULL, " +
                "OwnerId INTEGER NOT NULL, " +
                "FOREIGN KEY(PetId) REFERENCES Pets(Id), " +
                "FOREIGN KEY(OwnerId) REFERENCES Owners(Id))";
            command.ExecuteNonQuery();

            if(_connection != null)
            {
                _connection.Close();
            }
        }
    }
    
}
