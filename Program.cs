using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideVsOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            OriginalOutput messages = new OriginalOutput();
            OverrideOutput overridemessages = new OverrideOutput();

            do
            {
                messages.PrintInstructions();
                overridemessages.PrintInstructions();
                messages.PrintExtraLine();
                overridemessages.PrintExtraLine();

                var input = Console.ReadKey(true);
                int number = -1;

                if (!Char.IsDigit(input.KeyChar))
                {
                    string word = input.Key.ToString();
                    messages.ShowOutput(word);
                    overridemessages.ShowOutput(word);
                }
                else if (int.TryParse(input.KeyChar.ToString(), out number))
                {
                    messages.ShowOutput(number);
                    overridemessages.ShowOutput(number);
                }
                else
                {
                    Console.WriteLine("You didn't enter a number or a letter.");
                }

                messages.PrintLine();
                overridemessages.PrintLine();
                messages.PrintExtraLine();
                overridemessages.PrintExtraLine();

            } while (true);
        }
    }
}
