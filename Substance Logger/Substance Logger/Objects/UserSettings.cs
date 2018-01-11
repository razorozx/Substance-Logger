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
            LoadSettings();
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

        public void SaveSettings()
        {
            // save this object's members to the same folder it's executed on
            TextWriter file = new StreamWriter("logsettings.dat");

            // rewrite everything here
            file.WriteLine(disableClose);
            file.WriteLine(filePath);
            file.WriteLine(substances.Count);

            foreach (string item in substances)
            {
                file.WriteLine(item);                                // write substances
            }

            file.Close();
        }
        public void LoadSettings()
        {

            // checks if settings file exists, if it doesnt, don't load anything
            TextReader file;
            if (File.Exists("logsettings.dat"))
                file = new StreamReader("logsettings.dat");
            else
                return;

            // read file and dump into a string to extract from
            disableClose = (file.ReadLine() == "False") ? false : true; // manual convert bool to string
            filePath = file.ReadLine();
            int substanceCount = Convert.ToInt32(file.ReadLine());

            for (int i = 0; i < substanceCount; i++)
            {
                substances.Add(file.ReadLine());
            }

            file.Close();
        }

        /* sending the following bool as a ref from main
         form to other forms since sending in a ref bool
         won't work for some reason..*/
        public bool tick_refreshSubList = false;
        public bool close_quit = false;
    }
}
