using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes_Day4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting started with Abstract class and interface");
            Console.WriteLine("=========================================");
            


            Console.WriteLine("Here is an Abstract class example");
            Payment payment = new creditCardPayment(); //Creating an instance of the derived class
            payment.MakePayment(1000.00m); //Calling the abstract method implemented in the derived class
            payment.GenerateReceipt(); //Calling the concrete method from the base class                  

            Console.WriteLine("Implementing an interface");
            IPaymentGateway paymentGateway = new PayPalGateway(); //Creating an instance of the class that implements the interface
            paymentGateway.Pay(1500.00m); //Calling the Pay method from the interface
            paymentGateway.Refund(500.00m); //Calling the Refund method from the interface
            Console.WriteLine("=========================================");


        }

    }
    class creditCardPayment : Payment
    {
        public override void MakePayment(decimal amount)
        {
            //Implementation of the abstract method
            Console.WriteLine($"Payment of {amount} made using Credit Card. Payment ID: {PaymentId}");
            PaymentId = Guid.NewGuid().ToString();
            // Assign a new unique ID for the payment
            //Guid.NewGuid() generates a new globally unique identifier (GUID)


        }
    }
}

