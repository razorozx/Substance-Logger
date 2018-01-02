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
        public Tuple<string, string> selected;

        public void GetRandomQuestion()
        {
            // randomly get a QA from the list
            // place in selected
            // print that out in the closing form
        }

        Questions()
        {
            // hardcode questions and answers here
        }
    }
}
