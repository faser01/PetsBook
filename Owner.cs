using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsBook
{
    public class Owner
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int PetId { get; set; }

        public Owner(string firstName, string lastName, string address, string phone, int petId)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
            PetId = petId;
        }
    }
}
