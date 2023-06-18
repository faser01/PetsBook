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
    public partial class Schedule : Form
    {
        private Label labelType;
        private ComboBox comboBoxType;
        private Label labelDate;
        private DateTimePicker dateTimePickerDate;
        private Label labelTime;
        private DateTimePicker dateTimePickerTime;
        private Button buttonAdd;
        private Button buttonDelete;
        private ListBox listBoxNotifications;

        public Schedule()
        {
            InitializeComponent();
            MyDatabase database = new MyDatabase();
            // добавить обработчик событий для кнопок
            button1.Click += AddNotification;
            button2.Click += DeleteNotification;
        }



      

        private void AddNotification(object sender, EventArgs e)
        {
            // проверить, что пользователь ввел дату и время
            if (dateTimePicker1.Value == null || dateTimePicker2.Value == null)
            {
                MessageBox.Show("Введите дату и время уведомления!");
                return;
            }
            // создать строку с информацией об уведомлении
            string notification = $"{comboBox1.SelectedItem} - {dateTimePicker1.Value.ToShortDateString()} - {dateTimePicker2.Value.ToShortTimeString()}";

            // добавить строку в список уведомлений
            listBox1.Items.Add(notification);

            // создание подключения к базе данных
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=PetsDiary.db;Version=3;");
            connection.Open();

            // формирование SQL-запроса на добавление задачи
            string query = "INSERT INTO Schedule (Type, DateAndTime, PetId) VALUES (@type, @dateTime, @petId)";

            // создание объекта SQLiteCommand с параметрами
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@type", comboBox1.SelectedItem.ToString());
            command.Parameters.AddWithValue("@dateTime", dateTimePicker1.Value.ToString("yyyy-MM-dd") + " " + dateTimePicker2.Value.ToString("HH:mm:ss"));
            command.Parameters.AddWithValue("@petId", selectedPetId);

            // выполнение SQL-запроса
            command.ExecuteNonQuery();

            // закрытие подключения
            connection.Close();
        }

        private void DeleteNotification(object sender, EventArgs e)
        {
            // удалить выбранное уведомление из списка
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
