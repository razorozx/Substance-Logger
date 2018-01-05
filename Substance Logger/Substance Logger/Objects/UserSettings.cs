using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                    // file operations + directory

namespace Substance_Logger.Objects
{
    class UserSettings
    {
        bool inProgress = false;    // is the program recording?
        bool disableClose = false;
        List<Substance> substances = new List<Substance>();
        string fileName = null;
        DirectoryInfo saveLocation;

        void AddSubstance(string _substance)
        {
            // place new substance into substance list
        }
        void RemoveSubstance(string _substance)
        {
            // look for substance in the list
            // remove if found
            // if none found, do nothing
        }
        void LoadSubstances()
        {
            // when object is created, it loads substances from a file
            // only used in constructor
        }
        void SaveSettings()
        {
            // save this object's members to the same folder it's executed on
        }
    }
}
