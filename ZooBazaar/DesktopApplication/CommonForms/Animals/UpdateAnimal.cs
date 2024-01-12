using DesktopApplication.Adminstration.Animals;
using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Animals.Interfaces;
using Logic.Classes.Animal.Allergy;
using Data;
using Logic.Enums;
using Logic.Enums.Animal;
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
    public partial class UpdateAnimal : Form
    {
        private Logic.Interfaces.IAnimalAllergyManager AnimalAllergyManager;
        private Animal Animal { get; set; }
        private IAnimalManager animalManager = new AnimalManager(new AnimalDataManager());

        public UpdateAnimal(Animal animal)
        {
            InitializeComponent();

            AnimalAllergyManager = new AnimalAllergyManager(new AnimalAllergyDataManager());

            loadAnimalAllergiesCbx();
            loadAnimalLocationCbx();
            loadAnimalTypeCbx();
            loadGenderCbx();

            tbConfirmation1.Visible = false;

            this.Animal = animal;

            tbId.Text = Animal.Id.ToString();
            tbName.Text = Animal.Name.ToString();
            cbType.Text = Animal.AnimalType.ToString();

            if (animal.animalAllergy == null)
            {
                cbAllergies.Text = "";
            }
            else
            {
                cbAllergies.Text = Animal.animalAllergy.ToString();
            }

            cbGender.Text = Animal.Gender.ToString();
            cbLocation.Text = Animal.animalLocation.ToString();
            tbSicknesses.Text = Animal.Sicknesses.ToString();
            tbWeight.Text = Animal.Weight.ToString();
        }
        public void loadGenderCbx()
        {
            foreach (Gender gender in Enum.GetValues(typeof(Gender)))
            {
                cbGender.Items.Add(gender);
            }
        }
        public void loadAnimalTypeCbx()
        {
            foreach (AnimalType type in Enum.GetValues(typeof(AnimalType)))
            {
                cbType.Items.Add(type);
            }
        }
        public void loadAnimalLocationCbx()
        {
            foreach (AnimalLocation location in Enum.GetValues(typeof(AnimalLocation)))
            {
                cbLocation.Items.Add(location);
            }
        }
        public void loadAnimalAllergiesCbx()
        {
            cbAllergies.Items.Clear();

            foreach (AnimalAllergy animalAllergy in AnimalAllergyManager.GetAnimalAllergies())
            {
                cbAllergies.Items.Add(animalAllergy);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Animal.Name = tbName.Text;
            Animal.AnimalType = Enum.Parse<AnimalType>(cbType.Text);
            Animal.animalAllergy.Name = cbAllergies.Text;
            Animal.Gender = Enum.Parse<Gender>(cbGender.Text);
            Animal.animalLocation = Enum.Parse<AnimalLocation>(cbLocation.Text);
            Animal.Sicknesses = tbSicknesses.Text;
            Animal.Weight = int.Parse(tbWeight.Text);

            animalManager.EditAnimal(Animal);

            tbConfirmation1.Visible = true;
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            tbName.Text = "";
            cbType.Text = "";
            cbAllergies.Text = "";
            cbGender.Text = "";
            cbLocation.Text = "";
            tbSicknesses.Text = "";
            tbWeight.Text = "";
        }

        private void UpdateAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimalGeneralForm animalGeneralForm = new AnimalGeneralForm(new AccountTypes());
            animalGeneralForm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbConfirmation1.Visible = false;
        }
    }
}
