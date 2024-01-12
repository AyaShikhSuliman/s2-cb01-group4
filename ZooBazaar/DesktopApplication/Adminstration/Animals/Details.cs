using Logic.Animals.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication.CommonForms.Animals
{
    public partial class Details : Form
    {
        private Animal animal;
        private string illness;

        public Details(Animal animal, string illness)
        {
            InitializeComponent();
            this.animal = animal;
            this.illness = illness;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            lblId.Text = animal.Id.ToString();
            lblName.Text = animal.Name;
            lblDesc.Text = illness;
        }
    }
}
