using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Abstract_Classes_Day4_
{
    abstract class Payment

    //an abstract class is a class that cannot create an instance of itself and should have at least one abstract method
    //We can have only one Abstract class for child  class as C# does not support multiple inheritance


   

    {
        //defining class members lieke properties and methods specially one abstract method
        public string PaymentId { get; set; }
        public abstract void MakePayment(decimal amount);
        //here we are defining an abstract method
        //This is an abstract method that must be implemented by any derived class.

        public void GenerateReceipt()
        {
            //This is a concrete method that can be used by derived classes.
            Console.WriteLine($"Receipt generated for payment ID: {PaymentId}");

        }
    }
}
