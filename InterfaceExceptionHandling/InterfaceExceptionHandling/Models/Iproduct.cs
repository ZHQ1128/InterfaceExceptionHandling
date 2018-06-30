using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExceptionHandling.Models
{
    interface Iproduct
    {
        int GetPrice();
        void SetPrice(int value);

        int ChangePrice(int newPrice);
        void ShowInformation();

    }
}
