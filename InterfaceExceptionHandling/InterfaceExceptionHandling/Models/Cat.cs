using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExceptionHandling.Models
{
    class Cat : IAnimals,IInformationShower
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public string Sound { get; set; }

        public Cat (string name, int length)
        {
            Name = name;
            Length = length;
            Sound = "Meow";
        }

        public void MakeSound()
        {
            Console.WriteLine($"I'm a cat and I go {Sound}");
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Cat \nName: {Name}\nLength: {Length}\nSound: {Sound}");
        }
    }
}
