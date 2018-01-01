using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substance_Logger
{
    // This will mainly be used to recoed new doses and redoses
    struct Dosage
    {
        Substance substance;
        public long dose;
        public string doseType;             // ex: grams, ounces, liters, etc. Could use an enum, but thats a lot of work.
    }
}
