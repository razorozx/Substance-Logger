using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substance_Logger
{
    // basic entry to log progress. Ex: "T+0:23 - feeling effects"
    struct Entry
    {
        public string entryTime;                           // T+0:20
        public string realTime;                            // 3:20 PM
        public string experience;                          // user types in their experience here

        public bool dose;                                  // does the entry include a dose?
        public bool redose;                                //      if so, is it a redose?
        public Dosage dosage;
    }
}
