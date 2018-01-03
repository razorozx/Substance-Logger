using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substance_Logger
{
    // This will mainly be used to recored new doses and redoses
    class Dosage
    {
        public Dosage()
        {
            substance = new Substance();
            dosageUnit = new List<string>();
            chosenUnit = null;
            dose = 0;

            InitUnits();
        }

        private void InitUnits()
        {
            // Weight & Mass
            dosageUnit.Add("gram(s)");
            dosageUnit.Add("milligram(s)");
            dosageUnit.Add("microgram(s)");
            dosageUnit.Add("nanograms(s)");
            dosageUnit.Add("ounce(s)");

            // Volume
            dosageUnit.Add("liter(s)");
            dosageUnit.Add("milliliter(s)");
            dosageUnit.Add("fl ounce(s)");
            dosageUnit.Add("cup(s)");
            dosageUnit.Add("quart(s)");
            dosageUnit.Add("pint(s)");
            dosageUnit.Add("teaspoon(s)");
            dosageUnit.Add("tablespoon(s)");
        }

        Substance substance = new Substance();
        List<string> dosageUnit;                    // stores every type of dosing unit -- grams, ounces, liters, etc.
        public string chosenUnit;                   // stores the chosen dosageUnit
        public long dose;
    }
}
