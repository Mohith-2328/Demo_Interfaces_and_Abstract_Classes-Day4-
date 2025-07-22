using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes_Day4_
{
    internal interface IPaymentGateway
    {

        //here we will declare that will be implemented in the derived class

        void Pay(decimal amount);

        void Refund(decimal amount);
        

    }
    //define a class that implements the interface
    public class PayPalGateway : IPaymentGateway
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("PayPall payment a INR: " + amount);
        }

        public void Refund(decimal amount)
        {
            Console.WriteLine("PayPall refund a INR: " + amount);
        }
    }
}
