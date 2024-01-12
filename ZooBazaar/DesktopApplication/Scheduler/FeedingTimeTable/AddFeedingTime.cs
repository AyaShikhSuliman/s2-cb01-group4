using DesktopApplication.Adminstration.Animals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic.Enums;
using Logic.Animals.Enums;
using System.Security.AccessControl;
using Logic.Interfaces;
using Logic.Classes.FeedingTime;
using Logic.Animals.Interfaces;
using Logic.Animals.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using ComboBox = System.Windows.Forms.ComboBox;
using Logic.Enums.Animal;
using Data;
namespace DesktopApplication.Scheduler.Animals.FeedingTimetable
{
    public partial class AddFeedingTimeForm : Form
    {
        private IFeedingTimesManager feedingTimesManager;
        private AccountTypes _accountTypes;
        private Dictionary<string, int> times;

        private SqlConnection sqlConnection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi489597;User Id=dbi489597;Password=Group4Project;");

        public AddFeedingTimeForm(AccountTypes accountTypes)
        {
            InitializeComponent();

			tbConfirmation.Visible = false;

			feedingTimesManager = new FeedingTimesManager(new FeedingTimeDataManager());

            cbFoodtType.Items.AddRange(Enum.GetNames(typeof(AnimalFoodType)));

            _accountTypes = accountTypes;

            times = new Dictionary<string, int>();                  
        }
       
        private void AddFeedingTimeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FeedingTimetableForm feedingTimetableForm = new FeedingTimetableForm(_accountTypes);
            feedingTimetableForm.Show();
            this.Hide();
        }

        private void AddFeedingTimeForm_Load(object sender, EventArgs e)
        {
            cbAnimalType.Items.AddRange(Enum.GetNames(typeof(AnimalType)));
        }
       
        private void cbAnimalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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

                    if (cbAnimalType.SelectedItem.ToString() == animalType)
                    {
                        foreach (var animalAmount in animalAmountOfFood)
                        {
                            if (animalAmount.ToString() == animalType)
                            {
                                AnimalType animalType1 = Enum.Parse<AnimalType>(animalType);

                                tbFoodAmount.Text = feedingTimesManager.ReturnTotallFood(animalType1).ToString();
                                tbAmountOfAnimal.Text = feedingTimesManager.ReturnAmountOfChosenAnimalType(animalType1).ToString();
                                tbNeededTime.Text = feedingTimesManager.ReturnNeededTime(animalType, animalType1).ToString();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("There is no animal with this type in the system");
            }
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
			tbConfirmation.Visible = false;
		}

        private void button1_Click(object sender, EventArgs e)
        {
            string timesToBeFeed = cbFeedingTime.Text;
            AnimalType animalType = Enum.Parse<AnimalType>(cbAnimalType.Text);
            AnimalFoodType foodType = Enum.Parse<AnimalFoodType>(cbFoodtType.Text);
            int foodAmount = Convert.ToInt32(tbFoodAmount.Text);

            FeedingTime feedingTime = new FeedingTime(timesToBeFeed, animalType, foodType, foodAmount, 5);

            feedingTimesManager.AddFeedingTime(feedingTime);

            tbFoodAmount.Text = feedingTimesManager.ReturnTotallFood(animalType).ToString();

            tbConfirmation.Visible = true;
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            cbFeedingTime.Text = "";
            cbAnimalType.Text = "";
            cbFoodtType.Text = "";
            tbFoodAmount.Text = "";
        }
    }
}
