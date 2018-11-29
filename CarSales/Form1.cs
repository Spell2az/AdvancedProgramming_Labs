using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSales
{
    public partial class Form1 : Form
    {
        CarLot carLot;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carLot = new CarLot();


            Car car = new Car("Ford", "Focus", "FD62 GHY", new DateTime(2014, 4, 15), 17500, Vehicle.Condition.Excellent);
            Car car1 = new Car("Ford", "Fiesta", "RL58 HUZ", new DateTime(2013, 2, 17), 12500, Vehicle.Condition.Good);
            Van van1 = new Van("Volkswagen", "Transporter", "KL61 ABR", new DateTime(2011, 9, 13), 14500, Vehicle.Condition.Good, 745);
            carLot.AddVehicle(car);
            carLot.AddVehicle(car1);
            carLot.AddVehicle(van1);

            DisplayVehicle();

        }

        private void DisplayVehicle()
        {
            labelCurrentVehicle.Text = string.Format("Viewing {0} of {1}", carLot.VehicleCurrentlyDisplayed + 1, carLot.NumberOfVehicles);

            textBoxVehicle.Text = carLot.DescribeCurrentVehicle();

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            carLot.StepToPreviousVehicle();
            DisplayVehicle();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            carLot.StepToNextVehicle();
            DisplayVehicle();
        }
    }
}
