using System;
using LinqLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormIU
{
    public partial class Form1 : Form
    {
        List<Person> people = ListManager.LoadSampleData();

        public Dashboard()
        {
            InitializeComponent();

            InitializeBindings();
        }

        private void InitializeBindings()
        {
            allpeopleDropdown.DataSource = people;
            allpeopleDropdown.DisplayMember = "FullName";

            filteredpeopleList.Datasource = people.Where(x => x.YearsExperience >= 5).OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
            filteredpeopleList.DisplayMember = "FullName";
        }
        private void UpdateBindings()
        {
            filteredpeopleList.Datasource = people.Where(x => x.YearsExperience >= 5).OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ToList();
        }
        private void allPeopleDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)allpeopleDropdown.SelectedItem;

            yearsExperiencePicker.Value = selectedPerson.YearsExperience;
        }
        private void updatePersonButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)allpeopleDropdown.SelectedItem;

            selectedPerson.YearsExperience = Convert.ToInt32(yearsExperiencePicker.Value);

            UpdateBindings();
        }
    }
}
