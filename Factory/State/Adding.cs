using Factory;
using Factory.Abstractions;
using Factory.Enum;
using PizzaBuilding.Models;
using System;
using System.Collections.Generic;
using System.Text;
using PizzaBuilding.Implementations;

namespace PizzaBuilding.State
{
    public class Adding : Add
    {
        //add toppings
        public override string AddCheese(Context context, Order order)
        {
            order.AddToppingToOrder(new Topping(1, 1, ToppingType.Cheese));
            return "Cheese topping has been selected!\n";
        }
        public override string AddChicken(Context context, Order order)
        {
            order.AddToppingToOrder(new Topping(2, 1,ToppingType.Chicken));
            return "Chicken topping has been selected!\n";
        }
        public override string AddCorn(Context context, Order order)
        {
            order.AddToppingToOrder(new Topping(3, 1,ToppingType.Corn));
            return "Corn topping has been selected!\n";
        }
        public override string AddKetchup(Context context, Order order)
        {
            order.AddToppingToOrder(new Topping(4, 1,ToppingType.Ketchup));
            return "Ketchup topping has been selected!\n";
        }
        public override string AddMayo(Context context, Order order)
        {
            order.AddToppingToOrder(new Topping(5, 1,ToppingType.Mayo));
            return "Mayo topping has been selected!\n";
        }
        public override string AddMushrooms(Context context, Order order)
        {
            order.AddToppingToOrder(new Topping(6, 1,ToppingType.Mushrooms));
            return "Mushrooms topping has been selected!\n";
        }
        public override string AddMustard(Context context, Order order)
        {
            order.AddToppingToOrder(new Topping(7, 1,ToppingType.Mustard));
            return "Mustard topping has been selected!\n";
        }   
        // add pizzas
        public override string AddMargherita(Context context, Order order)
        {
            order.AddPizzaToOrder(new Pizza(1,5,PizzaType.Margherita));
            return "\nMargherita pizza has been selected!\n";
        }       
        public override string AddPepperoni(Context context, Order order)
        {
            order.AddPizzaToOrder(new Pizza(2, 6, PizzaType.Pepperoni));
            return "\nPepperoni pizza has been selected!\n";
        }      
        public override string AddQuattroFormaggio(Context context, Order order)
        {
            order.AddPizzaToOrder(new Pizza(3, 6, PizzaType.QuattroFormaggio));
            return "\nQuattroFormaggio pizza has been selected!\n";
        }   
        public override string AddRunningChicken(Context context, Order order)
        {
            order.AddPizzaToOrder(new Pizza(4, 6, PizzaType.RunningChicken));
            return "\nRunningChicken pizza has been selected!\n";
        }  
        public override string AddVeggie(Context context, Order order)
        {
            order.AddPizzaToOrder(new Pizza(5, 3, PizzaType.Veggie));
            return " \nVeggie pizza has been selected!\n";
        }

    }
}
