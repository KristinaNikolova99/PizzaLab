using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class Context
    {
        public Order order = new Order();
        public Add Add { get; set; }
        public Discard Discard { get; set; }
        public Payment Payment { get; set; }
        public void AddRequest(char c)
        {
            string result;
            switch (char.ToLower(c))
            {
                case '1':
                    result = Add.AddMilk(this, cart);

                    break;
                case '2':
                    result = Add.AddBread(this, cart);

                    break;
                case '3':
                    result = Add.AddEggs(this, cart);

                    break;
                case '4':
                    result = Add.AddOranges(this, cart);

                    break;
                case '5':
                    result = Add.AddPepsi(this, cart);

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
