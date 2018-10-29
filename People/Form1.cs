using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People
{
    public partial class Form1 : Form
    {
        // the form manages a birthdays Object
        Birthdays birthdays;

        public Form1()
        {
            InitializeComponent();        
        }
    


        private void Form1_Load(object sender, EventArgs e)
        {
            // we create a birthdays object
            birthdays = new Birthdays();
            AddPeople();

            // now we are ready to show the data on the form
            DisplayPerson();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            birthdays.StepToPreviousPerson();
            //and update the display
            DisplayPerson();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            birthdays.StepToNextPerson();
            // need to update the display here
            DisplayPerson();
        }

        public void AddPeople()
        {
            // in a real application this woulld be
            // read in from a database, a file or some
            // other source....

            // change the second name to yours with your date of birth

            birthdays.AddPerson("Pete", "Cooke", 2, 11, 1956);
            birthdays.AddPerson("Your", "Name", 1, 1, 2001);


            // test values here.
            birthdays.AddPerson("Yesterday", "Noname", 26, 10, 2001);
            birthdays.AddPerson("Today", "Noaame", 27, 10, 2001);
            birthdays.AddPerson("Tomorrow", "Noname", 28, 10, 2001);


        }

        public void DisplayPerson()
        {
            textBoxFirstName.Text = birthdays.GetPersonsFirstName();
            textBoxLastName.Text = birthdays.GetPersonsLastName();
            textBoxDateOfBirth.Text = birthdays.GetPersonsDateOfBirth();

            // add this
            textBoxDaysToBirthday.Text = string.Format("{0} Days", birthdays.GetPersonsDaysTillNextBirthday());
            textBoxAgeInYears.Text = string.Format("{0} Years old", birthdays.GetPersonsAgeInYears());
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int days = (int) numericUpDownDays.Value;

            string caption = $"Birthday in next {days} days";
            string message = birthdays.UpcomingBirthdays(days);
            if (string.IsNullOrEmpty(message))
            {
                message = "No birthdays found";
            }

            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            birthdays.Sort();
        }
    }
}
