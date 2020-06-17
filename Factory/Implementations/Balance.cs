using PizzaBuilding.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBuilding.Implementations
{
    public class Balance : IBalance
    {
        public int GetUserBalance(int userID)
        {
            Random rand = new Random();
            int balance = rand.Next(5, 25);
            Console.WriteLine("\t  Balance: " + balance);
            return balance;
        }
    }
}
