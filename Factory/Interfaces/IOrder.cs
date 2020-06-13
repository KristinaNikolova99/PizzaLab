using Factory;
using PizzaBuilding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBuilding.Interfaces
{
    public interface IOrder
    {
        string GetItemDetails(int productID);
        bool CheckItemAvailability(string product);
        bool LockItemInStock(int productID);
        string AddItemToCart(Topping topping);
        string DiscardItemFromCart(int id);
        double GetCartPrice(int cartID);
        int CheckProduct(int productID);
        int PlaceOrder(int cartID, int userID);

        void ApplyTax(int cartID, double taxPercent);
    }
}
