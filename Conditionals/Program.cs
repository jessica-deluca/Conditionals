using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {   //ask number of people in party
            Console.WriteLine("How many people are in your party?");
            int numberOfPeople = int.Parse(Console.ReadLine());

            //ask total bill of party
            Console.WriteLine("What is your total bill?");
            double totalBill = double.Parse(Console.ReadLine());

            //state variables
            double billWithDiscount;
            double costPerPerson;

            //give the discounts based on total bill of party
            if (totalBill >= 50)
            {
                billWithDiscount = totalBill * .9;
            }
            else
            {
                billWithDiscount = totalBill * .95;
            }

            //find cost per person and print receipt
            costPerPerson = billWithDiscount / numberOfPeople;
            Console.WriteLine("Cost Per Person: " + costPerPerson);
        }
    }
}
