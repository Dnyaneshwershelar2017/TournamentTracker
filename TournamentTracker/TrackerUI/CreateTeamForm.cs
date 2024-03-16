using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> avalableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            //avalableTeamMembers = GlobalConfig.Connection.getPerson_All();
            List<PersonModel> people = GlobalConfig.Connection.getPerson_All();
            
            //Remove selected person from availablePeople
            selectedTeamMembers.ForEach(x =>
            people.RemoveAt(people.FindIndex(y =>
            y.PersonId == x.PersonId)));

            avalableTeamMembers = people; 

            WireUpLists();
        }
        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;
            selectTeamMemberDropDown.DataSource = avalableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel(0,
                    firstNameTxt.Text,
                    lastNameTxt.Text,
                    emailTxt.Text,
                    mobileTxt.Text
                    );

                GlobalConfig.Connection.CreatePerson(p);


                firstNameTxt.Text = "";
                lastNameTxt.Text = "";
                emailTxt.Text = "";
                mobileTxt.Text = "";
                LoadData();
            }
            else
            {
                MessageBox.Show("Please enter valid inputs!");
            }
        }
        public bool ValidateForm()
        {

            if (firstNameTxt.Text.Length == 0 || lastNameTxt.Text.Length == 0 || emailTxt.Text.Length == 0 || mobileTxt.Text.Length < 10 || mobileTxt.Text.Length > 10)
                return false;

            if (!emailTxt.Text.Contains("@") || !emailTxt.Text.Split("@")[1].Contains(".") || !Char.IsLetter(emailTxt.Text[0]))
                return false;

            //TODO: Add Validation form
            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)selectTeamMemberDropDown.SelectedItem;
            selectedTeamMembers.Add(person);
            LoadData();
        }

        private void deleteSelectedMemberButton_Click(object sender, EventArgs e)
        {
            selectedTeamMembers.Remove((PersonModel)teamMembersListBox.SelectedItem);
            LoadData();
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            if (teamNameTxt.Text.Length > 0 && selectedTeamMembers.Count>0)
            {
                TeamModel team = new TeamModel(0, teamNameTxt.Text, selectedTeamMembers);
                team = GlobalConfig.Connection.CreateTeam(team);
            }
            else
            {
                MessageBox.Show("Please enter valid Team Details!");
            }
            //TODO: Id we aren't closing this form after creation, reset the form
        }
    }
}
