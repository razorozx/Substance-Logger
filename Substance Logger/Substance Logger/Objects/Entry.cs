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
        // use DateTime.Now.ToString("h:mm tt")
        string entryTime;                           // T+0:20
        string realTime;                            // 23:20
        string experience;                          // user types in their experience here

        bool dose;                                  // does the entry include a dose?
        bool redose;                                //      if so, is it a redose?
        Dosage dosage;
    }
}
