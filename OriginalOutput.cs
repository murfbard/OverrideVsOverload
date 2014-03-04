using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideVsOverload
{
    class OriginalOutput
    {
        /* 
         * OVERRIDE EXPLANATION (also see OverrideOutput.cs line:12)
         * This class serves as our base class.  The methods in here that are marked
         * with the virtual keyword can be overridden by methods in derived classes 
         * that use this class as a base class.  Notice I said "CAN BE" overridden.  
         * If I marked these as abstract, than these methods MUST be overriden. 
         */

        /*
         * OVERLOAD EXPLANATION (also see OverrideOutput.cs line:20)
         * The following two methods have the same name but are passed different types 
         * of parameters.  Although the names are the same, your code will choose the 
         * correct function based on the type of parameter passed with it.  You must pass
         * different parameters passed to each version of the function for this to work.
         */
        public virtual void ShowOutput(int i)
        {
            Console.WriteLine("This is the base numeric ShowOutput method");
        }
        public virtual void ShowOutput(string s)
        {
            Console.WriteLine("This is the base string ShowOutput method");
        }

        public void PrintLine()
        {
            Console.WriteLine("--------------");
        }

        public void PrintInstructions()
        {
            Console.WriteLine("Type a single number or letter.");
        }
        public void PrintExtraLine()
        {
            Console.WriteLine("");
        }
    }
}
