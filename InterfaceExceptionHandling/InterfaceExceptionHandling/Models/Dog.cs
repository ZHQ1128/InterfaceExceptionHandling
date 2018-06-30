using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExceptionHandling.Models
{
    class Dog : IAnimals, IInformationShower
    {
        public string Name { get ; set; }
        public int Length { get ; set ; }
        public string Sound { get ; set ; }

        public Dog (string name, int length)
        {
            this.Name = name;
            this.Length = length;
            this.Sound = "woof";
        }

        public void MakeSound()
        {
            Console.WriteLine($"I'm a dog and I go {Sound}");
        }

        public void ShowInformation()
        {
            Console.WriteLine($"Dog \nName: {Name}\nLength: {Length}\nSound: {Sound}");
        }
    }
}
