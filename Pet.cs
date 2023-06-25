using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsBook
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public Image Photo { get; set; }

        public Pet(string name, string breed, int age, Image photo)
        {
            Name = name;
            Breed = breed;
            Age = age;
            Photo = photo;
        }
    }
}
