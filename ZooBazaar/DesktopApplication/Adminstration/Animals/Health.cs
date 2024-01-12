using DesktopApplication.Adminstration.Employees;
using DesktopApplication.CommonForms.Animals;
using Logic.Animals.Classes;
using Logic.Animals.Interfaces;
using Logic.Enums;
using Data;


namespace DesktopApplication.Adminstration.Animals
{
    public partial class HealthForm : Form
    {
        private IAnimalManager _animalManager;

        public HealthForm()
        {
            InitializeComponent();
            _animalManager = new AnimalManager(new AnimalDataManager());
        }

        private void HealthForm_Load(object sender, EventArgs e)
        {
            foreach (Animal animal in _animalManager.ShowAllAnimals())
            {
                if (!string.IsNullOrEmpty(animal.Sicknesses))
                {
                    lbSickness.Items.Add(animal);
                }
            }

            foreach (Animal animal in _animalManager.ShowAllAnimals())
            {
                if (animal.animalAllergy != null)
                {
                    lbAllergies.Items.Add(animal);
                }
            }
        }

        private void HealthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ALoginOptionsForm aE = new ALoginOptionsForm(new AccountTypes());
            aE.SetAnimalButtons();
            aE.Show();
            this.Hide();
        }

        private void lbSickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbSickness.SelectedIndex >= 0)
            {
                Animal animal = (Animal)lbSickness.SelectedItem;
                Details details = new Details(animal, animal.Sicknesses);
                details.ShowDialog();
            }
        }

        private void lbAllergies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAllergies.SelectedIndex >= 0)
            {
                Animal animal = (Animal)lbAllergies.SelectedItem;
                Details details = new Details(animal, animal.animalAllergy.ToString());
                details.ShowDialog();
            }
        }

        private void tbSearchSickness_Click(object sender, EventArgs e)
        {
            int index;
            string input;

            input = tbSicknesses.Text;
            index = Convert.ToInt32(lbSickness.FindString(input));

            if (index != ListBox.NoMatches)
            {
                MessageBox.Show("Animal is found!");
            }
            else
            {
                MessageBox.Show("Animal not found!");
            }
        }

        private void tbSearchAllergy_Click(object sender, EventArgs e)
        {
            int index;
            string input;

            input = tbAllergies.Text;
            index = Convert.ToInt32(lbAllergies.FindString(input));

            if (index != ListBox.NoMatches)
            {
                MessageBox.Show("Animal is found!");
            }
            else
            {
                MessageBox.Show("Animal not found!");
            }
        }
    }    
}
