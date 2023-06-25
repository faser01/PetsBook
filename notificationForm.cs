using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsBook
{
    public partial class notificationForm : Form
    {
        public notificationForm(string type, string dateTime, int petId)
        {
            InitializeComponent();
            lblType.Text = type;
            lblDateTime.Text = dateTime;
            lblPetId.Text = petId.ToString();
        }
    }
}
