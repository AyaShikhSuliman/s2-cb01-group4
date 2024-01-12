using DesktopApplication.Adminstration.Animals;
using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Animals.Interfaces;
using Data;
using Logic.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Enums.Animal;
using Logic.Classes.Animal.Allergy;
using Logic.Interfaces;

namespace DesktopApplication.CommonForms.Animals
{
    public partial class AddAnimalForm : Form
    {
        private IAnimalManager _animals;
        private IAnimalAllergyManager AnimalAllergyManager;

        public AddAnimalForm()
        {
            InitializeComponent();

            _animals = new AnimalManager(new AnimalDataManager());
            AnimalAllergyManager = new AnimalAllergyManager(new AnimalAllergyDataManager());

            InitializeComboboxes();

            tbConfirmation.Visible = false;
        }

        private void InitializeComboboxes()
        {
            cbType.Items.AddRange(Enum.GetNames(typeof(AnimalType)));

            cbAllergies.Items.Clear();

            foreach (AnimalAllergy animalAllergy in AnimalAllergyManager.GetAnimalAllergies())
            {
                cbAllergies.Items.Add(animalAllergy);
            }

            cbGender.Items.AddRange(Enum.GetNames(typeof(Gender)));
            cbLocation.Items.AddRange(Enum.GetNames(typeof(AnimalLocation)));
            cbFoodType.Items.AddRange(Enum.GetNames(typeof(AnimalFoodType)));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string name = tbName.Text;
            Gender animalGender = Enum.Parse<Gender>(cbGender.Text);
            int weight = Convert.ToInt32(tbWeight.Text);
            AnimalType animalType = Enum.Parse<AnimalType>(cbType.Text);
            AnimalLocation animalLocation = Enum.Parse<AnimalLocation>(cbLocation.Text);
            AnimalAllergy animalAllergy = (AnimalAllergy)cbAllergies.SelectedItem;
            AnimalFoodType animalFoodType = Enum.Parse<AnimalFoodType>(cbFoodType.Text);
            AnimalAmountOfFood animalAmountOfFood = Enum.Parse<AnimalAmountOfFood>(tbFoodAmount.Text);
            string sicknesses = tbSicknesses.Text;

            Animal animal = new Animal(name, animalGender, weight,
                animalType, animalAllergy, sicknesses, animalLocation, animalFoodType, animalAmountOfFood);

            _animals.AddAnimal(animal);

            tbConfirmation.Visible = true;
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            tbName.Text = "";
            tbSicknesses.Text = "";
            tbWeight.Text = "";
            cbLocation.Text = "";
            cbAllergies.Text = "";
            cbGender.Text = "";
            cbType.Text = "";
            cbFoodType.Text = "";

            MessageBox.Show("Please make sure the necessary inputs are given");

        }

        private void AddAnimalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimalGeneralForm animalGeneralForm = new AnimalGeneralForm(new AccountTypes());
            animalGeneralForm.Show();
            this.Hide();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> animalTypes = new List<string>();
            animalTypes.AddRange(Enum.GetNames(typeof(AnimalType)));
            List<AnimalAmountOfFood> animalAmountOfFood = new List<AnimalAmountOfFood>();

            foreach (int i in Enum.GetValues(typeof(AnimalAmountOfFood)))
            {
                animalAmountOfFood.Add((AnimalAmountOfFood)i);
            }

            foreach (string animalType in animalTypes)
            {

                if (cbType.SelectedItem.ToString() == animalType)
                {
                    foreach (var animalAmount in animalAmountOfFood)
                    {
                        if (animalAmount.ToString() == animalType)
                        {
                            tbFoodAmount.Text = Convert.ToInt32(animalAmount).ToString();
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbConfirmation.Visible = false;
        }
    }
}
