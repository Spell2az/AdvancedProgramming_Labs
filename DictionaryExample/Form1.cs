using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryExample
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> countryAndPopulation = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            countryAndPopulation.Add("China", 123123123);
            countryAndPopulation.Add("UK", 754342);
            countryAndPopulation.Add("France", 851342);
            countryAndPopulation.Add("Chile", 21342);
            countryAndPopulation.Add("Peru", 1342);
            countryAndPopulation.Add("Tibet", 99342);
            countryAndPopulation.Add("Canada", 1121342);
            countryAndPopulation.Add("Spain", 2221342);
            countryAndPopulation.Add("Italy", 33421342);

            InitializeCountriesComboBox();
        }

        private void InitializeCountriesComboBox()
        {
            comboBoxCountry.Items.Clear();

            foreach (KeyValuePair<string, int> keyValuePair in countryAndPopulation)
            {
                comboBoxCountry.Items.Add(keyValuePair.Key);
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = comboBoxCountry.SelectedItem.ToString();

            textBoxPopulation.Text = countryAndPopulation[selectedItem].ToString("###,###,###,###");

        }
    }
}
