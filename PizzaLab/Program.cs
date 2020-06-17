using Factory;
using Factory.Enum;
using System;

namespace PizzaLab
{
    //factory,state,facade
    class Program
    {
        static void Main(string[] args)
        {
            Implem imp = new Implem();
            imp.SelectPizza();
            if (imp.through == true || imp.through2 == true)
            {
                imp.PlaceOrder();
            }
            

        }
    }
}
