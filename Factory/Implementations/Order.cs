using Factory;
using System;
using System.Collections.Generic;
using System.Text;
using PizzaBuilding.Abstractions;
using System.Linq;
using PizzaBuilding.Models;
using PizzaBuilding.Interfaces;
using PizzaBuilding.State;

namespace PizzaBuilding.Implementations
{
    public class Order : BaseOrder,IOrder
    {
        public override List<Topping> _order { get; set; } = new List<Topping>();
        public Pizza pizza;
        public string AddToppingToOrder(Topping topping)
        {
            this._order.Add(topping);
            CheckTopping(topping.ToppingID);
            if (topping == null)
            {
                return "Failed to add topping";
            }
            return "Topping has been succesfully added";
        }        
        public string AddPizzaToOrder(Pizza pizza)
        {
            this.pizza = pizza;
            if (pizza == null)
            {
                return "Failed to add pizza";
            }
            return "Pizza has been succesfully added";
        }


        public string DiscardToppingFromOrder(int id)
        {
            var rawProduct = this._order.FirstOrDefault(i => i.ToppingID == id);
            this._order.Remove(rawProduct);
            if (rawProduct == null)
            {
                return "Failed to remove topping";
            }
            return "Topping has been removed successfully";
        }
        public bool CheckItemAvailability(string topping)
        {
            if (topping != null)
            {
                return true;
            }
            return false;
        }
        public int GetOrderPrice(int cartID)
        {
            var ProductsCost = this._order.Sum(i => i.Cost) + pizza.Cost;
            Console.WriteLine("\t  Total price: " + ProductsCost);
            return ProductsCost;
        }
        public int GetItemCalories(int id)
        {
            var rawProduct = this._order.FirstOrDefault(i => i.ToppingID == id);
            if (rawProduct == null)
            {
                return 0;
            }
            int result = 0;
            switch (id)
            {
                case 1: result = 160; break;
                case 2: result = 100; break;
                case 3: result = 50; break;
                case 4: result = 30; break;
                case 5: result = 80; break;
                case 6: result = 70; break;
                case 7: result = 40; break;
                default:; result = 0; break;
            }
            return result;
        }
        public int GetPizzaCalories(int id) 
        {
            var rawPizza = this.pizza.PizzaID;
            if (rawPizza == 0)
            {
                return 0;
            }
            int result = 0;
            switch (id)
            {
                case 1: result = 699; break;
                case 2: result = 900; break;
                case 3: result = 1200; break;
                case 4: result = 920; break;
                case 5: result = 420; break;  
                default:; result = 0; break;
            }
            return result;
        }
        public int TotalCalories()
        {
            int toppingsC = 0;
            foreach (var item in _order)
            {
               int c =  GetItemCalories(item.ToppingID);
                toppingsC = toppingsC + c;                
            }
            int pizzaC = GetPizzaCalories(this.pizza.PizzaID);
            int calories = pizzaC + toppingsC;
            return calories;
        }
        public string GetItemDetails(int id)
        {
            var rawProduct = this._order.FirstOrDefault(i => i.ToppingID == id);
            if (rawProduct == null)
            {
                return "Topping not found";
            }
            return $"Topping: {rawProduct.ToppingTypeSet} - {rawProduct.Cost}";
        }
        public void PrintOrder()
        {
            foreach (var item in _order)
            {
                Console.WriteLine(item.ToppingTypeSet);
            }
        }
        public int PlaceOrderDetails(int balance, int total)
        {
            Console.WriteLine("\t  Money left: {0}", balance - total);
            return 0;
        }


        public int CheckTopping(int toppingID)
        {
            Console.WriteLine("\nChecking topping...");
            //Step 1 : GetTopping
            string topping = GetItemDetails(toppingID);
            //Step 2 : Check Availability
            if (topping != "Topping not found")
            {
                if (CheckItemAvailability(topping))
                {
                    //Step 3 
                    Console.WriteLine("Topping available");
                }
            }
            else
            {
                Console.WriteLine("Topping not found");
            }
            int calories = GetItemCalories(toppingID);
            Console.WriteLine("Topping calories:" + calories);
            Console.WriteLine("Check has ended");
            return toppingID;
        }

        public int PlaceOrder(int orderID, int userID)
        {
            Console.WriteLine("Order:\n{0} pizza with:", pizza.PizzaTypeSet);
            PrintOrder();
            IBalance balance = new Balance();     
            //Step 1 : Get user balance
            int userWalletBalance = balance.GetUserBalance(userID);
            //Step 2 : Get the order items price
            int orderPrice = GetOrderPrice(orderID);
            //Step 3 : Compare the balance and price
            if (userWalletBalance >= orderPrice)
            {
                //Step 4 : Place the order
                orderID = PlaceOrderDetails(userWalletBalance, orderPrice);
            }
            else
            {
                Console.WriteLine("\t  Not enough money!");
            }
            //Step 5 : calculation total calories            
            int cal = TotalCalories();
            Console.WriteLine("\t  Total calories: {0}", cal);
            Console.WriteLine("End order");
            return orderID;
        }

    }
}
