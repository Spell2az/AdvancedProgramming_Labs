using System.Collections.Generic;

namespace CarSales
{
    public class CarLot
    {
        private List<Vehicle> vehicleStock = new List<Vehicle>();
        private int vehicleCurrentlyDisplayed = 0;


        public int VehicleCurrentlyDisplayed => vehicleCurrentlyDisplayed;
        public int NumberOfVehicles => vehicleStock.Count;

        public string DescribeCurrentVehicle()
        {
            return NumberOfVehicles > 0
                ? vehicleStock[vehicleCurrentlyDisplayed].Description()
                : "No Vehicles in stock";
        }

        public void AddVehicle(Vehicle vehicle) => vehicleStock.Add(vehicle);

        public void RemoveVehicle(int index)
        {
            if (index < vehicleStock.Count)
            {
                vehicleStock.RemoveAt(index);
                LegaliseVehicleCurrentlyDisplayed();
            }
        }

        private void LegaliseVehicleCurrentlyDisplayed()
        {
            if (vehicleCurrentlyDisplayed > (vehicleStock.Count - 1))
            {
                vehicleCurrentlyDisplayed = vehicleStock.Count - 1;

                if (vehicleCurrentlyDisplayed < 0)
                {
                    vehicleCurrentlyDisplayed = 0;
                }
            }
        }

        public void StepToNextVehicle()
        {
            vehicleCurrentlyDisplayed =
                vehicleCurrentlyDisplayed + 1 > vehicleStock.Count - 1 ? 0 : vehicleCurrentlyDisplayed + 1;
        }

        public void StepToPreviousVehicle()
        {
            int nextVehicleDisplayed = vehicleCurrentlyDisplayed - 1;
            vehicleCurrentlyDisplayed =
                (vehicleCurrentlyDisplayed - 1) < 0 ? NumberOfVehicles - 1 : nextVehicleDisplayed;
        }
    }
}