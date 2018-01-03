using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substance_Logger
{
    struct Substance
    {
        /* substances will be recorded so when the user uses 
         * the substance again there will be a dropdown box to choose
         * the substance for ease of use.
         */
        string name;
        List<string> dosageUnit;            // stores unit of measurement. later to be implemented as an 'ease of use' feature when making a dose entry
        
        Substance(string _name)
        {
            name = _name;
            dosageUnit = new List<string>();
        }

        void AddUnit(string _unit)
        {
            dosageUnit.Add(_unit);
        }
        
    }
}
