using Factory.Abstractions;
using PizzaBuilding.Abstractions;
using PizzaBuilding.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBuilding.State
{
    public class Context
    {
        public Order order = new Order();
        public Add Add { get; set; }
        public Discard Discard { get; set; }
        //public Payment Payment { get; set; }
        public void AddToppingRequest(char c)
        {
            string result;
            switch (char.ToLower(c))
            {
                case '1':
                    result = Add.AddCheese(this, order);
                    break;

                case '2':
                    result = Add.AddChicken(this, order);
                    break;

                case '3':
                    result = Add.AddCorn(this, order);
                    break;

                case '4':
                    result = Add.AddKetchup(this, order);
                    break;

                case '5':
                    result = Add.AddMayo(this, order);
                    break;

                case '6':
                    result = Add.AddMushrooms(this, order);
                    break;

                case '7':
                    result = Add.AddMustard(this, order);
                    break;

                case 'f':
                    result = "";
                    break;
                default:
                    result = "   Try again";
                    break;
            }
            Console.WriteLine(result);
        }
        public void AddPizzaRequest(char c)
        {
            string result;
            switch (char.ToLower(c))
            {
                case '1':
                    result = Add.AddMargherita(this, order);
                    break;

                case '2':
                    result = Add.AddPepperoni(this, order);
                    break;

                case '3':
                    result = Add.AddQuattroFormaggio(this, order);
                    break;

                case '4':
                    result = Add.AddRunningChicken(this, order);
                    break;

                case '5':
                    result = Add.AddVeggie(this, order);
                    break;

                case 'f':
                    result = "";
                    break;
                default:
                    result = "   Try again";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}

