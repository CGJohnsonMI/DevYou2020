using System;
namespace MadLib
{
    class Program
    {
        private static char Main(string[] args)
        {
            //****************************************
            //Week 1 project
            //Christopher Johnson
            //Due 20201101
            //****************************************

            //Variable declaration

            string adjective;
            string noun;
            string PastTense;
            string adverb;
            string verb;
            string space " ";

            Console.WriteLine($"MadLib Story Time");

            //prompt adjective
            Console.WriteLine($"Please enter an adjective:");
            adjective = Console.ReadLine();

            //Prompt noun
            Console.WriteLine($"Please enter a noun:");
            noun = Console.ReadLine();

            //Prompt verb
            Console.WriteLine($"Please enter a verb:");
            verb = Console.ReadLine();

            //Prompt adverb
            Console.WriteLine($"Please enter an adverb:");
            adverb = Console.ReadLine();

            //Prompt PastTense
            Console.WriteLine($"Please enter a past tense verb:");
            PastTense = Console.ReadLine();

            Console.WriteLine($"Today I went to the zoo. I saw a " + adjective +
                space + noun + " jumping up and down in its tree." + " He " +
                PastTense + space + adverb + "  through the large tunnel that led to its " + adjective + space +
                noun + space + "I got some peanuts and passed them" +
                " through the cage to a gigantic gray " + noun +
                " towering above my head. Feeding that animal made me " +
                "hungry. I went to get a " + adjective + " scoop of ice " +
                " cream. It filled my stomach. Afterwards I had to " +
                verb + space + adverb + "to catch our bus. When " +
                "I got home I " + PastTense + " my mom for a " + adjective + " day at the zoo.");

            Console.WriteLine($"Great story! Press any key to exit the Mad Lib");

            Console.ReadKey();
        }
    }
}