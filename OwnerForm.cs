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
    public partial class OwnerForm : Form
    {
        private readonly string connectionString = "Data Source=PetsDiary.db;Version=3;";
        private int petId;
        private Label nameLabel;
        private Label surnameLabel;
        private Label addressLabel;
        private Label phoneLabel;
        private TextBox nameTextBox;
        private TextBox surnameTextBox;
        private TextBox addressTextBox;
        private TextBox phoneTextBox;

        public OwnerForm(int petId)
        {
            this.petId = petId;
            InitializeComponent();
            FillFormWithOwnerData();
            Show();
        }

        private void InitializeComponent()
        {
            nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(10, 10);
            nameLabel.Text = "Имя:";

            nameTextBox = new TextBox();
            nameTextBox.Location = new Point(100, 10);
            nameTextBox.Size = new Size(150, 20);

            surnameLabel = new Label();
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(10, 40);
            surnameLabel.Text = "Фамилия:";

            surnameTextBox = new TextBox();
            surnameTextBox.Location = new Point(100, 40);
            surnameTextBox.Size = new Size(150, 20);

            addressLabel = new Label();
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(10, 70);
            addressLabel.Text = "Адрес:";

            addressTextBox = new TextBox();
            addressTextBox.Location = new Point(100, 70);
            addressTextBox.Size = new Size(150, 20);

            phoneLabel = new Label();
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(10, 100);
            phoneLabel.Text = "Телефон:";

            phoneTextBox = new TextBox();
            phoneTextBox.Location = new Point(100, 100);
            phoneTextBox.Size = new Size(150, 20);

            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(surnameLabel);
            Controls.Add(surnameTextBox);
            Controls.Add(addressLabel);
            Controls.Add(addressTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(phoneTextBox);
        }

        private void FillFormWithOwnerData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM owners WHERE pet_id = @PetId";
                command.Parameters.AddWithValue("@PetId", petId);
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nameTextBox.Text = reader["first_name"].ToString();
                    surnameTextBox.Text = reader["last_name"].ToString();
                    addressTextBox.Text = reader["address"].ToString();
                    phoneTextBox.Text = reader["phone"].ToString();
                }
                reader.Close();
            }
        }
    }
    }