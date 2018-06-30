using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExceptionHandling.CustomExceptions;  // remember this

namespace InterfaceExceptionHandling.Models
{
    class Temperature
    {
        int temperature;
        public Temperature(int temp)
        {
            temperature = temp;
        }
        public void ChangeTemp(int temp)
        {
            try
            {
               this.temperature = temp;  // remove this?
                if (temperature ==0)
                {
                    throw (new TemperatureIsZeroException("your temp can't be zero"));
                }
            }
            catch (TemperatureIsZeroException e)
            {

                Console.WriteLine(
                    e.Message.ToString());
            }

        }
    }
}
