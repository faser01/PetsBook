using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace PetsBook
{
    public partial class Form3 : Form
    {
        private readonly List <Pet> pets;
        private List <Owner> owners;
        private List <Notifications> notifications;
        private SQLiteConnection _connection;
        private int userId;

        public Form3(List<Pet> pets, List<Owner> owners, List <Notifications> notifications, SQLiteConnection connection, int userId)
        {
            InitializeComponent();
            this.pets = pets;
            this.owners = owners;
            this.notifications = notifications;
            DisplayPets();
        }

        private void DisplayPets()
        {
            dataGridViewPets.Rows.Clear();
            foreach (var pet in pets)
            {
                dataGridViewPets.Rows.Add(pet.Name, pet.Breed, pet.Age, pet.Photo);
            }
        }
       

        private void dataGridViewPets_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPets.SelectedRows.Count > 0)
            {
                var selectedPet = pets[dataGridViewPets.SelectedRows[0].Index];
                var selectedOwner = owners.FirstOrDefault(o => o.PetId == selectedPet.Id);
                var selectedNotifications = notifications.Where(n => n.PetId == selectedPet.Id).ToList();
                textBoxPetName.Text = selectedPet.Name;
                textBoxPetBreed.Text = selectedPet.Breed;
                textBoxPetAge.Text = selectedPet.Age.ToString();
                pictureBoxPetPhoto.Image = selectedPet.Photo;

                if (selectedOwner != null)
                {
                    textBoxOwnerFirstName.Text = selectedOwner.FirstName;
                    textBoxOwnerLastName.Text = selectedOwner.LastName;
                    textBoxOwnerAddress.Text = selectedOwner.Address;
                    textBoxOwnerPhone.Text = selectedOwner.Phone;
                }

                listBoxNotifications.Items.Clear();
                foreach (var notification in selectedNotifications)
                {
                    listBoxNotifications.Items.Add(notification.Type + " " + notification.DateTime);
                }
            }
        }

        private void buttonAddPet_Click(object sender, EventArgs e)
        {
            using (var formAddPet = new FormAddPet(pets, _connection, userId))
            {
                formAddPet.ShowDialog();
                DisplayPets();
            }
        }

        private void buttonEditPet_Click(object sender, EventArgs e)
        {
            if (dataGridViewPets.SelectedRows.Count > 0)
            {
                var selectedPet = pets[dataGridViewPets.SelectedRows[0].Index];
                var selectedOwner = owners.FirstOrDefault(o => o.PetId == selectedPet.Id);
                var formEditPet = new FormEditPet(selectedPet, selectedOwner);
                formEditPet.ShowDialog();
                DisplayPets();
            }
        }

        private void buttonDeletePet_Click(object sender, EventArgs e)
        {
            if (dataGridViewPets.SelectedRows.Count > 0)
            {
                var selectedPet = pets[dataGridViewPets.SelectedRows[0].Index];
                var selectedOwner = owners.FirstOrDefault(o => o.PetId == selectedPet.Id);
                var selectedNotifications = notifications.Where(n => n.PetId == selectedPet.Id).ToList();
                pets.Remove(selectedPet);

                if (selectedOwner != null)
                {
                    owners.Remove(selectedOwner);
                }

                foreach (var notification in selectedNotifications)
                {
                    notifications.Remove(notification);
                }

                DisplayPets();
            }
        }
    }
}
