using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExceptionHandling.Models;

namespace InterfaceExceptionHandling
{
    class Program
    {
        //Information shower method
        static void Main(string[] args)
        {
            //Products p = new Products("Ipad", 800, "Table",1);
            //p.ShowInformation();
            //p.ChangePrice(750);
            ////p.ShowInformation();
            //Products d = p;
            ////d.ShowInformation();
            //d.SetPrice(100);
            //p.ShowInformation();

            //Cat c = new Cat("mimi", 30);
            //Dog d = new Dog("wangwang",50);
            //d.ShowInformation();
            //c.MakeSound();

            //NumberDivider d = new NumberDivider();
            //// Console.WriteLine(d.Divide(10,3));
            //d.Divide(25, 0);

            //Temperature t = new Temperature(20);
            ////t.ShowTemp();
            //t.ChangeTemp(15);
            Eggs e = new Eggs();
            e.BuyEgg();


        }
    }
}
