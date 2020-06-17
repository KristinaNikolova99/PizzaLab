using Factory;
using PizzaBuilding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBuilding.Interfaces
{
    public interface IOrder
    {
        int GetItemCalories(int toppingID);
        string GetItemDetails(int toppingID);
        bool CheckItemAvailability(string product);
        string AddToppingToOrder(Topping topping);
        string AddPizzaToOrder(Pizza pizza);
        string DiscardToppingFromOrder(int id);
        int GetOrderPrice(int cartID);
        int CheckTopping(int productID);

        int PlaceOrderDetails(int balance, int total);
    }
}
