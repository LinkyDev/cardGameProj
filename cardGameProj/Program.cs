using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGameProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card(5, CardSuit.Diamond);
            Card card2 = new Card(2, CardSuit.Club);

            if (card1 > card2) Console.WriteLine(">");
        }
    }
}
