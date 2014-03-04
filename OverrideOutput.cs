using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideVsOverload
{
    class OverrideOutput : OriginalOutput
    {
        /*
         * OVERRIDE EXPLANATION (also see OriginalOutput.cs line:12)
         * This class serves as our derived class.  The methods in here that are marked
         * with the override keyword will overwrite methods in the base class.  Methods
         * created in the base class can be used by this derived class as long as they are
         * markted public or protected.
         */

        /*
         * OVERLOAD EXPLANATION (also see OriginalOutput.cs line:20)
         * The following two methods have the same name but are passed different types 
         * of parameters.  Although the names are the same, your code will choose the 
         * correct function based on the type of parameter passed with it.  You must pass
         * different parameters passed to each version of the function for this to work.
         */
        public override void ShowOutput(string s)
        {
            Console.WriteLine("OVERRIDE! string output is " + s);
        }

        public override void ShowOutput(int i)
        {
            Console.WriteLine("OVERRIDE! numeric output is " + i);
        }
    }
}
