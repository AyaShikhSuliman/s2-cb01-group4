using DesktopApplication.Adminstration.Employees;
using DesktopApplication.CommonForms.Animals;
using DesktopApplication.Scheduler.Animals;
using Logic.Animals.Classes;
using Logic.Animals.Enums;
using Logic.Animals.Interfaces;
using Logic.Interfaces;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Logic.Classes.Accounts;
using Logic.Enums;
namespace DesktopApplication.Adminstration.Animals
{
    public partial class AnimalGeneralForm : Form
    {
        private DataTable dataTable;
        private DataView dataView;
        Animal selectedAnimal;
        private IAnimalManager _animals;
        private ILoginManager login;
        private AccountTypes _accountTypes;

        public AnimalGeneralForm(AccountTypes accountTypes)
        {
            InitializeComponent();
            InitializeComboboxes();

            _animals = new AnimalManager(new Data.AnimalDataManager());
            login = new AccountsManager();
            _accountTypes = accountTypes;

            //Listview properties
            lvAnimals.View = View.Details;
            lvAnimals.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //Add columns
            lvAnimals.Columns.Add("Id", 50);
            lvAnimals.Columns.Add("Type", 100);
            lvAnimals.Columns.Add("Name", 100);

            //Initialize dataTable and add columns
            dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Name");

            if (_accountTypes == AccountTypes.Scheduler)
            {
                btnAdd.Visible = false;
                btnRemove.Visible = false;
                btnEdit.Visible = false;
                return;

            }
            else if (_accountTypes == AccountTypes.Admin)
            {
                btnAdd.Visible = true;
                btnRemove.Visible = true;
                btnEdit.Visible = true;
                return;
            }

            btnAdd.Visible = false;
            btnRemove.Visible = false;
            btnEdit.Visible = false;
        }

        private void InitializeComboboxes()
        {
            cbType.Items.AddRange(Enum.GetNames(typeof(AnimalType)));
        }

        private void PopulateListView(DataView dataView)
        {
            lvAnimals.Items.Clear();

            foreach (DataRow row in dataView.ToTable().Rows)
            {
                lvAnimals.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString() }));
            }
        }

        private void AnimalGeneralForm_Load(object sender, EventArgs e)
        {
            ShowAllAnimals();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvAnimals.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show($"Are you sure you want to delete this Animal?",
                    "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    if (lvAnimals.SelectedItems.Count == 0) return;
                    ListViewItem item = lvAnimals.SelectedItems[0];
                    int id = int.Parse(item.SubItems[0].Text);
                    Animal animal = _animals.GetAnimalById(id);
                    _animals.RemoveAnimal(animal);

                    for (int i = lvAnimals.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem listViewItem = lvAnimals.SelectedItems[i];
                        lvAnimals.Items[listViewItem.Index].Remove();

                    }
                }
            }
            else
            {
                MessageBox.Show("Select an Animal first!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            dataView.RowFilter = String.Format("Id Like '%{0}%'", tbId.Text);
            PopulateListView(dataView);
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataView.RowFilter = String.Format("Type Like '%{0}%'", cbType.Text);
            PopulateListView(dataView);
        }

        private void cbType_TextChanged(object sender, EventArgs e)
        {
            if (cbType.Text == "")
            {
                dataView = new DataView(dataTable);
                PopulateListView(dataView);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAnimalForm addAnimalForm = new AddAnimalForm();
            addAnimalForm.Show();
            this.Hide();
        }

        private void AnimalGeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_accountTypes == AccountTypes.Scheduler)
            {
                SLoginOptionsForm sLoginOptionsForm = new SLoginOptionsForm(_accountTypes);
                sLoginOptionsForm.SetAnimalButtons();
                sLoginOptionsForm.Show();
                this.Hide();
                return;
            }
            else if (_accountTypes == AccountTypes.Admin)
            {
                ALoginOptionsForm aloginOptionsForm = new ALoginOptionsForm(_accountTypes);
                aloginOptionsForm.SetAnimalButtons();
                aloginOptionsForm.Show();
                this.Hide();
                return;
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            dataView.RowFilter = String.Format("Name Like '%{0}%'", tbName.Text);
            PopulateListView(dataView);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.selectedAnimal != null)
            {
                Animal animal = this.selectedAnimal;
                UpdateAnimal updateAnimal = new UpdateAnimal(animal);
                updateAnimal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nothing Selected");
            }
        }

        private void lvAnimals_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lvAnimals.SelectedItems.Count == 0) return;
            ListViewItem item = lvAnimals.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);
            Animal animal = _animals.GetAnimalById(id);
            this.selectedAnimal = animal;
        }

        private void ShowAllAnimals()
        {
            dataTable.Clear();
            if (_animals != null)
            {
                foreach (Animal animal in _animals.ShowAllAnimals())
                {
                    dataTable.Rows.Add(animal.Id, animal.AnimalType, animal.Name);
                }

                dataView = new DataView(dataTable);
                PopulateListView(dataView);
            }
        }
    }
}
