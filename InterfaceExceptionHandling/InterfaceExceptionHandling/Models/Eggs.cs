using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExceptionHandling.CustomExceptions;

namespace InterfaceExceptionHandling.Models
{
    class Eggs
    {
        public void BuyEgg()
        {
        Console.WriteLine("How many eggs would you like to buy? Please no more than 12.");
            int eggs = int.Parse(Console.ReadLine());
        bool keepGoing = true;
            while (keepGoing)
            {
                try
                {
                    if (eggs > 12)
                    {
                        throw (new TooManyEggsException("You cannot buy more than 12 eggs"));
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You have bought {eggs} eggs.");
                        keepGoing = false;
                    }
                }
                catch (TooManyEggsException e)
                {
                    Console.WriteLine(e.Message.ToString());
                    Console.WriteLine($"How many eggs would you like?");
                    eggs = int.Parse(Console.ReadLine());
                }
            }   
        }
    }
}
