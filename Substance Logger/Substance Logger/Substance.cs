using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substance_Logger
{
    struct Substance
    {
        // all of these structs will be logged in a file so the user can pick them later on from a dropdown box
        public string name;
        List<Substance> interactions;

        #region Constructors
        // constructors may not be needed since everything is public and could be set regardless of constructors

        Substance(List<Substance> _interact)
        {
            interactions = _interact;
            name = null;
        }
        Substance(string _name, List<Substance> _interact)
        {
            interactions = _interact;
            name = _name;
        }
        Substance(string _name)
        {
            interactions = new List<Substance>();
            name = _name;
        }

        #endregion
    }

    struct Dosage
    {
        Substance substance;
        public long dose;
        public string doseType;             // ex: grams, ounces, liters, etc.


    }
}
