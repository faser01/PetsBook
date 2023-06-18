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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnNewPet_Click(object sender, EventArgs e)
        {
            autorization form = new autorization();
            form.Show();
            this.Hide();
        }
    }
}
