using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string monologue = "I've seen things you people wouldn't believe... " +
                "Attack ships on fire off the shoulder of Orion... " +
                "I watched C-beams glitter in the dark near the Tannhäuser Gate. " +
                "All those moments will be lost in time, like tears in rain...  Time to die.";

            string[] separateMonologue = monologue.Split(' ');

            foreach (string word in separateMonologue)
            {
                Console.WriteLine(word);
            }            
        }
    }
}
