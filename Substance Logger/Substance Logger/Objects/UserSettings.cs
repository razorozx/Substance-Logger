using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;                                                // file operations + directory

namespace Substance_Logger.Objects
{
    public class UserSettings
    {
        public bool disableClose = false;
        public List<string> substances = new List<string>();    // loaded substances
        public string fileName = null;
        public string filePath = null;

        public UserSettings()
        {
            // check if load file exists
            // if so, load settings from file
        }

        public void AddSubstance(string _sub)
        {
            // check if substance already exists, if so, skip it
            // if it doesn't, add it

            for (int i = 0; i < substances.Count; i++)
            {
                if (substances[i] == _sub)
                {
                    return;
                }
            }
            substances.Add(_sub);
        }
        public void RemoveSubstance(string _sub)
        {
            // look for substance in the list
            for (int i = 0; i < substances.Count; i++)
            {
                if (substances[i] == _sub)
                {
                    substances.RemoveAt(i);
                }
            }
        }
        public void LoadSubstances()
        {
            // loads substances from a file (from same execution place or save folder)
            // this is only to be used in the constructor

            // check if file exists to load data
            //   if none exists, start out with nothing
            //   else load it up
        }
        public void SaveSettings()
        {
            // save this object's members to the same folder it's executed on
        }

        /* sending the following bool as a ref from main
         form to other forms since sending in a ref bool
         won't work for some reason..*/
        public bool tick_refreshSubList = false;
        public bool close_quit = false;
    }
}
