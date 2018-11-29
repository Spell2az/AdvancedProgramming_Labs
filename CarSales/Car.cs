using System;
using Microsoft.Win32.SafeHandles;

namespace CarSales
{
    public class Car: Vehicle
    {
        public Car(string registration, string make, string model, DateTime dateManufactured, decimal originalPrice, Condition condition)
            : base(registration, make, model, dateManufactured, originalPrice, condition)
        {
        }

        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;

            switch (condition)
            {
                case Condition.Excellent:
                    value = originalPrice * 0.6m;
                    break;
                case Condition.Good:
                    value = originalPrice * 0.5m;
                    break;
                case Condition.Fair:
                    value = originalPrice * 0.4m;
                    break;
                case Condition.Poor:
                    value = originalPrice * 0.3m;
                    break;
            }

            int age = CalculateApproximateAgeInYears();

            value = value * (decimal) Math.Pow(0.9, age);

            value = Decimal.Round(value, 0);

            return value - (value % 100) + 99;
        }
    }
}