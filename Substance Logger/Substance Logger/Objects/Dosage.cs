using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substance_Logger
{
    // This will mainly be used to recored new doses and redoses
    struct Dosage
    {
        Dosage(int x)   // ignore the parameter, it is forcably required..
        {
            substance = new Substance();
            dosageUnit = new List<string>();
            chosenDoseType = null;
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

        List<string> dosageUnit;                    // stores every type of dosing unit -- grams, ounces, liters, etc.
        Substance substance;
        public long dose;
        public string chosenDoseType;               // stores the chosen dosageUnit
    }
}
