using Factory.Enum;
using PizzaBuilding.State;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace PizzaLab
{
    public class Implem
    {
        private Context context = new Context();
        private int command = 0;
        public bool through;
        public bool through2;

        //selecting pizza, if true ->topping selection
        public void SelectPizza()
        {
            context.Add = new Adding();
            string choice = "";
            bool check = false;
            while (choice != "f")
            {
                Console.WriteLine(
                    "Please select a pizza base!(esc to cancel)" +
                    "\n'1' for Margherita(699 calories)," +
                    "\n'2' for Pepperoni(900 calories)," +
                    "\n'3' for QuattroFormaggio(1200 calories)," +
                    "\n'4' for RunningChicken(920 calories)," +
                    "\n'5' for Veggie(420 calories)");
                choice = ReadLineWithCancel();
                Console.WriteLine();
                var myEnumMemberCount = Enum.GetNames(typeof(PizzaType)).Length;
                bool isNumeric = int.TryParse(choice, out _);
                if (choice.Length == 1 && isNumeric == true)
                {
                    if (choice == "" || int.Parse(choice) <= 0 || int.Parse(choice) > myEnumMemberCount ||
                        choice.Length > 1 || isNumeric == false)
                    {
                        Console.WriteLine("\nInvalid input, try again!\n");
                    }
                    else
                    {
                        if (choice != null && choice != "" && int.Parse(choice) > 0 &&
                            int.Parse(choice) <= myEnumMemberCount && choice.Length == 1 && choice != "f")
                        {
                            command = int.Parse(choice);
                            context.AddPizzaRequest(command);
                            check = true;
                            break;
                        }
                    }
                }
                else if (choice == "f") { }
                else { Console.WriteLine("\nInvalid input, try again!\n"); }
            }
            if (check == true)
            {
                SelectTopping();
            }
            else 
            {
                through = false;
                Console.WriteLine("You canceled the order .");
                Console.ReadKey();
            }
        }
        //method for selecting toppings
        public void SelectTopping()
        {
            context.Add = new Adding();
            string choice = "";
            bool check = false;
            string choiceD = "";
            while (choiceD.Length != 1)
            {
                Console.WriteLine("Do u wish to add any toppings? y/n");
                choiceD = Console.ReadLine();
                if (choiceD == "y" || choiceD == "n") { }

                else
                {
                    Console.WriteLine("\nInvalid input, try again!\n");
                    choiceD = "";
                }
            }
            if (choiceD == "y")
            {
                while (choice != "f")
                {
                    Console.WriteLine(
                        "\nWhich topping would u like?(press esc for no toppings or to stop)" +
                        "\n'1' for Cheese(160 calories)," +
                        "\n'2' for Chicken(100 calories)," +
                        "\n'3' for Corn(50 calories)," +
                        "\n'4' for Mayo(30 calories)," +
                        "\n'5' for Mushrooms(80 calories)," +
                        "\n'6' for Mustard(70 calories)," +
                        "\n'7' for Ketchup(40 calories)");
                    choice = ReadLineWithCancel();
                    Console.WriteLine();
                    var myEnumMemberCount = Enum.GetNames(typeof(ToppingType)).Length;
                    bool isNumeric = int.TryParse(choice, out _);
                    if (choice.Length == 1 && isNumeric == true)
                    {
                        if (choice == "" || int.Parse(choice) <= 0 || int.Parse(choice) > myEnumMemberCount ||
                            choice.Length > 1 || isNumeric == false)
                        {
                            Console.WriteLine("Invalid input, try again!\n");
                        }
                        else
                        {
                            if (choice != null && choice != "" && int.Parse(choice) > 0 &&
                                int.Parse(choice) <= myEnumMemberCount && choice.Length == 1 && choice != "f")
                            {
                                command = int.Parse(choice);
                                context.AddToppingRequest(command);
                                check = true;
                            }
                        }
                    }
                    else if(choice == "f") { through2 = true; }
                    else
                    {
                        Console.WriteLine("\nInvalid input, try again!");
                    }
                }
            }
            if(choiceD == "n")
            {
                through2 = true;
                Console.WriteLine("Proceeding to orderdetails..");
            }
            if (check == true)
            {
                DiscardTopping();
            }
        }

        //method for discarding toppings from order
        public void DiscardTopping()
        {
            string choiceD = "";
            string choiceDD = "";
            context.Discard = new Discarding();
            while (choiceD.Length != 1)
            {
                Console.WriteLine("\nAll topings selected:");
                context.PrintOrder();
                Console.WriteLine("\nDo u wish to discard any of the selected toppings? y/n");
                choiceD = Console.ReadLine();
                if (choiceD == "y" || choiceD == "n") {
                    through2 = true;
                }

                else
                {
                    Console.WriteLine("\nInvalid input, try again!\n");
                    choiceD = "";
                }
            }

            if (choiceD == "y")
            {
                while (choiceDD != "f")
                {
                    Console.WriteLine(
                        "\nWhich topping would u like to discard?(esc to cancel)" +
                        "\n'1' for Cheese," +
                        "\n'2' for Chicken," +
                        "\n'3' for Corn," +
                        "\n'4' for Mayo," +
                        "\n'5' for Mushrooms," +
                        "\n'6' for Mustard," +
                        "\n'7' for Ketchup");
                    choiceDD = ReadLineWithCancel();
                    Console.WriteLine();
                    var myEnumMemberCount = Enum.GetNames(typeof(ToppingType)).Length;
                    bool isNumeric = int.TryParse(choiceDD, out _);
                    if (choiceDD.Length == 1 && isNumeric == true)
                    {
                        if (choiceDD == "" || int.Parse(choiceDD) <= 0 || int.Parse(choiceDD) > myEnumMemberCount ||
                            choiceDD.Length > 1 || isNumeric == false)
                        {
                            Console.WriteLine("\nInvalid input, try again!\n");
                        }
                        else
                        {
                            if (choiceDD != null && choiceDD != "" && int.Parse(choiceDD) > 0 &&
                                        int.Parse(choiceDD) <= myEnumMemberCount && choiceDD.Length == 1 && choiceDD != "f")
                            {
                                command = int.Parse(choiceDD);
                                context.DiscardToppings(command);
                            }
                            Console.WriteLine("Your toppings:");
                            context.PrintOrder();
                        }
                    }
                    else if (choiceDD == "f") { through2 = true; }
                    else
                    {
                        Console.WriteLine("\nInvalid input, try again!");
                    }
                }
            }
            if (choiceD == "n" || through2 == true)
            {
                Console.WriteLine("Proceeding to orderdetails..");
            }
        }
        //method for escaping the while with (esc)
        private string ReadLineWithCancel()
        {
            string result = "f";
            StringBuilder buffer = new StringBuilder();
            ConsoleKeyInfo info = Console.ReadKey(true);

            while (info.Key != ConsoleKey.Enter && info.Key != ConsoleKey.Escape)
            {
                Console.Write(info.KeyChar);
                buffer.Append(info.KeyChar);
                info = Console.ReadKey(true);
            }

            if (info.Key == ConsoleKey.Enter)
            {
                result = buffer.ToString();
            }
            return result;
        }
       
        //method for final order details
        public void PlaceOrder()
        {
            Random rand = new Random();
            int orderID;
            int userID;
            orderID = rand.Next(1, 2000);
            userID = rand.Next(1, 2000);
            Console.WriteLine("************************************");
            context.order.PlaceOrder(orderID, userID);
            Console.WriteLine("************************************");
            Console.ReadLine();
        }

    }
}
