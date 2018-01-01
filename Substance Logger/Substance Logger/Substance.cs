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
}
