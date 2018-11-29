using System;

namespace CarSales
{
    public class Van: Vehicle
    {
        protected double payload;
        public Van(string registration, string make, string model, DateTime dateManufactured, decimal originalPrice, Condition condition, double payload) 
            : base(registration, make, model, dateManufactured, originalPrice, condition)
        {
            this.payload = payload;
        }

        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;

            switch (condition)
            {
                case Condition.Excellent:
                    value = originalPrice * 0.7m;
                    break;
                case Condition.Good:
                    value = originalPrice * 0.6m;
                    break;
                case Condition.Fair:
                    value = originalPrice * 0.5m;
                    break;
                case Condition.Poor:
                    value = originalPrice * 0.4m;
                    break;
            }

            int age = CalculateApproximateAgeInYears();

            value = value * (decimal)Math.Pow(0.95, age);

            value = Decimal.Round(value, 0);

            return value - (value % 100) + 99;
        }

        public override string Description()
        {
            return base.Description() + Environment.NewLine +
                   $"Payload: {payload}";
        }
    }
}