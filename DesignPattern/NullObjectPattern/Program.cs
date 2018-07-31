using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{

    //https://www.codeproject.com/Articles/1042674/NULL-Object-Design-Pattern
    class Program
    {
        static void Main(string[] args)
        {
            var premiumOrder = new Order(new PremiumDiscount());
            premiumOrder.CalculateDiscount();

            var festivalOrder = new Order(new FestivalDiscount());
            festivalOrder.CalculateDiscount();

            //here is the pattern
            var noDiscountOrder = new Order(new NullDiscount());
            noDiscountOrder.CalculateDiscount();
        }
    }

   
}
