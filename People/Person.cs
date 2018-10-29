using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Person : IComparable
    {
        // attributes for this class

        private string firstName;
        private string lastName;
        private int dayBorn;
        private int monthBorn;
        private int yearBorn;

        public string FirstName
        {
            get { return firstName; }
            set { FirstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int DayBorn
        {
            get { return dayBorn; }
            set { dayBorn = value; }
        }

        public int MonthBorn
        {
            get { return monthBorn; }
            set { monthBorn = value; }
        }

        public int YearBorn
        {
            get { return yearBorn; }
            set { yearBorn = value; }
        }

        public Person()
        {
            
        }

        public Person(string firstName, string lastName, int dayBorn, int monthBorn, int yearBorn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dayBorn = dayBorn;
            this.monthBorn = monthBorn;
            this.yearBorn = yearBorn;
        }

        // helper method - return date of birth as a string

        public string DateOfBirth()
        {
            return string.Format("{0}/{1}/{2}", DayBorn, MonthBorn, YearBorn);
        }


        // these 3 methods implement an algorithm to
        // calculate ho many days it is to your next birthday

        public bool HadThisYearsBirthday()
        {
            // get todays date
            DateTime today = DateTime.Today;

            // we assume you have not had this years birthday yet
            bool returnValue = false;

            // but if this month is AFTER you birthay month you have
            if (today.Month > MonthBorn)
            {
                returnValue = true;
            }
            // if this is your birthday month we look at the days            
            else if (today.Month == MonthBorn)
            {
                // if today is on or after your birthday then you have
                if (today.Day >= DayBorn)
                {
                    returnValue = true;
                }

            }
            return returnValue;
        }


        public DateTime GetNextBirthday()
        {
            // we calculate the date for your next birthday
            DateTime today = DateTime.Today;
            // assume your birthday is this year
            int birthdayYear = today.Year;
            // if you've already had your birthday then
            // its a year later
            if (HadThisYearsBirthday())
            {
                birthdayYear++;
            }
            // now we create the right dateTime
            DateTime nextBirthday =
                new DateTime(birthdayYear, MonthBorn, DayBorn);
            return nextBirthday;
        }

        public int HowManyDaysTillBirthday()
        {
            // we work out the difference between your next birthday
            // and todays date

            DateTime nextBirthday = GetNextBirthday();
            DateTime today = DateTime.Today;

            TimeSpan difference =
                nextBirthday.Subtract(today);

            // from the timespan object we are only interested in the
            // number of days
            int daysToBirthday = difference.Days;

            return daysToBirthday;
        }

        // code for extension work

        public int GetAgeInYears()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - YearBorn;

            // but if you haven't had this years birthday
            // you are 1 year younger

            if (!HadThisYearsBirthday())
            {
                age--;
            }
            return age;
        }


        public bool IsOlderThan(Person otherPerson)
        {
            return GetAgeSpan() > otherPerson.GetAgeSpan();
        }

        public bool IsSameAgeAs(Person otherPerson)
        {
            return GetAgeSpan() == otherPerson.GetAgeSpan();
        }

        private TimeSpan GetAgeSpan()
        {
            DateTime dateOfBirth = new DateTime(yearBorn, monthBorn, dayBorn);
            return dateOfBirth - DateTime.Now;
        }

        public int CompareTo(object obj)
        {
            Person otherPerson = (Person) obj;

            if (IsOlderThan(otherPerson))
            {
                return 1;
            }
            else if (IsSameAgeAs(otherPerson))
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}



