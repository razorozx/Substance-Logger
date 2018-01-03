using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substance_Logger.Objects
{
    // This class contains hard-coded questions to ask the user on the closing window
    class Questions
    {
        // holds a list of questions and answers (hence QA)
        List<Tuple<string, string>> QA;
        public Tuple<string, string> selected;                                                  // made public to be available to the window

        public void GetRandomQuestion()
        {
            Random random = new Random();
            int randomNum = random.Next(0, QA.Count);                                           // random Question & Answer picker
            selected = new Tuple<string, string>(QA[randomNum].Item1, QA[randomNum].Item2);     // get QA and store it
        }

        public Questions()
        {
            // hard-coded questions and answers here
            // questions must be under 61 characters long (so it can fit in the window)
            QA = new List<Tuple<string, string>>();

            // Arithmetic
            QA.Add(new Tuple<string, string>("100 - 75 + 20 = ", "45"));
            QA.Add(new Tuple<string, string>("12.5 + 2.5 = ", "15"));
            QA.Add(new Tuple<string, string>("115 - 25 = ", "90"));
            QA.Add(new Tuple<string, string>("15 - 39 = ", "54"));
            QA.Add(new Tuple<string, string>("115 - 25 = ", "90"));

            // Word stuff
            QA.Add(new Tuple<string, string>("What has 4 legs, has a tail, is man's best friend, and barks?", "dog"));
            QA.Add(new Tuple<string, string>("What has shines beautifully, very hard, and is expensive?", "diamond"));
            QA.Add(new Tuple<string, string>("Complete the sequence: yesterday, today, ______", "tomorrow"));
            QA.Add(new Tuple<string, string>("What superhero is called: The Man of Steel, Superboy, _____", "superman"));
            QA.Add(new Tuple<string, string>("What is the first letter of the alphabet?", "a"));

            // "Type in"
            QA.Add(new Tuple<string, string>("Type in 'Hello, World!'", "Hello, World!"));
            QA.Add(new Tuple<string, string>("Type in 'I had fun!'", "I had fun!"));
            QA.Add(new Tuple<string, string>("Type in 'Jaws of Life'", "Jaws of Life"));
            QA.Add(new Tuple<string, string>("Type in 'An Arm and a Leg'", "An Arm and a Leg"));
            QA.Add(new Tuple<string, string>("Type in 'Down To Earth'", "Down To Earth"));

            GetRandomQuestion();                                                                // preselected question (just in case)
        }
    }
}
