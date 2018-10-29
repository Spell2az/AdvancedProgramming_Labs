
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
            return people[currentPerson].firstName;
        }

        public string GetPersonsLastName()
        {
            return people[currentPerson].lastName;
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


        public bool IsNextPerson()
        {
            if (currentPerson < (people.Count - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
            // we could just write
            //return (currentPerson < (people.Count - 1));
        }
        
        public bool IsPreviousPerson()
        {
            if (currentPerson > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            // again we could write
            // return (currentPerson > 0);
        }


        public void StepToNextPerson()
        {
            if (IsNextPerson())
            {
                currentPerson++;
            }
        }

        public void StepToPreviousPerson()
        {
            if (IsPreviousPerson())
            {
                currentPerson--;
            }
        }

        public void AddPerson(string firstName, string lastName, int dayBorn, int monthBorn, int yearBorn)
        {
            // create a new person object
            Person person = new Person();
            // copy in tyhe details
            person.firstName = firstName;
            person.lastName = lastName;
            person.dayBorn = dayBorn;
            person.monthBorn = monthBorn;
            person.yearBorn = yearBorn;
            // add to the list of people
            people.Add(person);
        }
    }
}
