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

        public void AddToppingRequest(int c)
        {
            string result;
            switch (c)
            {
                case 1:
                    result = Add.AddCheese(this, order);
                    break;

                case 2:
                    result = Add.AddChicken(this, order);
                    break;

                case 3:
                    result = Add.AddCorn(this, order);
                    break;

                case 4:
                    result = Add.AddKetchup(this, order);
                    break;

                case 5:
                    result = Add.AddMayo(this, order);
                    break;

                case 6:
                    result = Add.AddMushrooms(this, order);
                    break;

                case 7:
                    result = Add.AddMustard(this, order);
                    break;

                default:
                    result = "\nInvalid input, try again!\n";
                    break;
            }
            Console.WriteLine(result);
        }
        public void AddPizzaRequest(int c)
        {
            string result;
            switch (c)
            {
                case 1:
                    result = Add.AddMargherita(this, order);
                    break;

                case 2:
                    result = Add.AddPepperoni(this, order);
                    break;

                case 3:
                    result = Add.AddQuattroFormaggio(this, order);
                    break;

                case 4:
                    result = Add.AddRunningChicken(this, order);
                    break;

                case 5:
                    result = Add.AddVeggie(this, order);
                    break;
                                    
                default:
                    result = "\nInvalid input, try again!\n";
                    break;
            }
            Console.WriteLine(result);
        }
        public void DiscardToppings(int c)
        {
            string result;
            switch (c)
            {
                case 1:
                    result = Discard.DiscardCheese(this, order);
                    break;

                case 2:
                    result = Discard.DiscardChicken(this, order);
                    break;

                case 3:
                    result = Discard.DiscardCorn(this, order);
                    break;

                case 4:
                    result = Discard.DiscardMayo(this, order);
                    break;

                case 5:
                    result = Discard.DiscardMushrooms(this, order);
                    break;

                case 6:
                    result = Discard.DiscardMustard(this, order);
                    break;

                case 7:
                    result = Discard.DiscardKetchup(this, order);
                    break;

                default:
                    result = "\nInvalid input, try again!\n";
                    break;
            }
            Console.WriteLine(result);
        }
        public void PrintOrder()
        {
            foreach (var item in order._order)
            {
                Console.WriteLine(item.ToppingTypeSet);
            }
        }
    }
}

