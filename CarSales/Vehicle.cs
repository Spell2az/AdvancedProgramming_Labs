using System;

namespace CarSales
{
    public abstract class Vehicle: IComparable
    {
        public enum Condition
        {
            Poor,
            Fair,
            Good,
            Excellent
        }

        protected string registration;
        protected string make;
        protected string model;
        protected DateTime dateManufactured;
        protected decimal originalPrice;
        protected Condition condition;

        protected Vehicle(string registration, string make, string model, DateTime dateManufactured, decimal originalPrice, Condition condition)
        {
            this.registration = registration;
            this.make = make;
            this.model = model;
            this.dateManufactured = dateManufactured;
            this.originalPrice = originalPrice;
            this.condition = condition;
        }

        public int CalculateApproximateAgeInYears()
        {
            var now = DateTime.Now;
            var age = now.Year - dateManufactured.Year;

            return age;
        }

        public abstract decimal CalculateApproximateValue();

        public virtual string Description()
        {
            string conditionName = Enum.GetName(typeof(Condition), condition);

            return $"Make: {make}" + Environment.NewLine +
                   $"Model: {model}" + Environment.NewLine +
                   $"Registration: {registration}" + Environment.NewLine +
                   $"Condition: {conditionName}" + Environment.NewLine +
                   $"Current Value: {CalculateApproximateValue()}";
          }

        public int CompareTo(object obj)
        {
            Vehicle otherVehicle = (Vehicle) obj;
            decimal priceDifference = this.CalculateApproximateValue() - otherVehicle.CalculateApproximateValue();

            return Math.Sign(priceDifference);
        }
    }
}