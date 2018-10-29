using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Person
    {
        // attributes for this class

        public string firstName;
        public string lastName;
        public int dayBorn;
        public int monthBorn;
        public int yearBorn;



        // helper method - return date of birth as a string

        public string DateOfBirth()
        {
            return string.Format("{0}/{1}/{2}", dayBorn, monthBorn, yearBorn);
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
            if (today.Month > monthBorn)
            {
                returnValue = true;
            }
            // if this is your birthday month we look at the days            
            else if (today.Month == monthBorn)
            {
                // if today is on or after your birthday then you have
                if (today.Day >= dayBorn)
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
                new DateTime(birthdayYear, monthBorn, dayBorn);
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
            int age = today.Year - yearBorn;

            // but if you haven't had this years birthday
            // you are 1 year younger

            if (!HadThisYearsBirthday())
            {
                age--;
            }
            return age;
        }



    }
}



