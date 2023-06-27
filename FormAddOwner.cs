using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsBook
{
    public partial class FormAddOwner : Form
    {
        private readonly Pet _pet;
        private readonly List<Owner> _owners;
        public FormAddOwner(Pet pet, List<Owner> owners)
        {
            InitializeComponent();
            _pet = pet;
            _owners = owners;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Проверяем, что все поля заполнены
            if (string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text) ||
                string.IsNullOrEmpty(textBoxAddress.Text) || string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создаем новый объект владельца и добавляем его в список
            var newOwner = new Owner(_pet.Id.ToString(), textBoxFirstName.Text, textBoxLastName.Text, textBoxAddress.Text, int.Parse (textBoxPhone.Text));
            _owners.Add(newOwner);

            // Закрываем форму
            Close();
        }

       
    }
}
