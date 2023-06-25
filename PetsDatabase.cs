using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsBook
{
    public static class PetsDatabase
    {

        public static List<Pet> Pets { get; set; } = new List<Pet>();
        public static List<Owner> Owners { get; set; } = new List<Owner>();

    }
}
