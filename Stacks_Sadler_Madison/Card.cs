// System namespace needed to use Console class
using System;
// System.Collections.Generic namespace needed to use Console class
using System.Collections.Generic;
// System.Linq namespace needed to use Console class
using System.Linq;
// System.Text namespace needed to use Console class
using System.Text;
// System.Threading.Tasks namespace needed to use Console class
using System.Threading.Tasks;

// My collection of classes for this project
namespace Stacks_Sadler_Madison
{
    // Creates a class called Card
    internal class Card
    {
        // Creates a public string property called Number with an automatic getter
        public string Number { get; }

        // Creates a public string property called Suit with an automatic getter
        public string Suit { get; }

        // Creates a public constructor called Card that takes string parameters numParam and suitParam
        public Card(string numParam, string suitParam)
        {
            // Sets Number to numParam
            Number = numParam;
            // Sets Suit to suitParam
            Suit = suitParam;
        }
    }
}
