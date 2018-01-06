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
        public string substance;
        public string chosenUnit;                   // stores the chosen dosageUnit
        public string amount;
    }
}
