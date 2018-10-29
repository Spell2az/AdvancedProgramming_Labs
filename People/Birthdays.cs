
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Birthdays
    {
        // attributes

        List<Person> people = new List<Person>();

        int currentPerson = 0;


        //we need access to a persons data

        public string GetPersonsFirstName()
        {
            return people[currentPerson].FirstName;
        }

        public string GetPersonsLastName()
        {
            return people[currentPerson].LastName;
        }

        public string GetPersonsDateOfBirth()
        {
            return people[currentPerson].DateOfBirth();            
        }

        public int GetPersonsDaysTillNextBirthday()
        {
            return people[currentPerson].HowManyDaysTillBirthday();
        }

        // added for extension task
        public int GetPersonsAgeInYears()
        {
            return people[currentPerson].GetAgeInYears();
        }

        public void StepToNextPerson()
        {
            currentPerson = currentPerson == (people.Count - 1) ? 0 : currentPerson + 1;
        }

        public void StepToPreviousPerson()
        {
            currentPerson = currentPerson == 0 ? people.Count -1 : currentPerson - 1;
        }

        public void AddPerson(string firstName, string lastName, int dayBorn, int monthBorn, int yearBorn)
        {
            people.Add(new Person(firstName, lastName, dayBorn, monthBorn, yearBorn));
        }

        public string UpcomingBirthdays(int days)
        {
            var names = people
                            .Where(person => person.HowManyDaysTillBirthday() <= days)
                            .Select(person => $"{person.FirstName} {person.LastName} {person.DateOfBirth()}");
           
            return String.Join(Environment.NewLine, names);
        }
    }
}
