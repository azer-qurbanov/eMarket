using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.Data.Entities;
using eMarket.Services;

namespace eMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {
            MarketServices services = new MarketServices();
            int selection = 0;
            do
            {
                Console.WriteLine("1. Mehsullar");
                Console.WriteLine("2. Satışlar");
                Console.WriteLine("3. Çıxış");


                string selectionStr = Console.ReadLine();
                selection = int.Parse(selectionStr);


                switch (selection)
                {
                    case 1:
                        productmenu.Productmenu();
                        break;
                    case 2:
                        break;
                    case 3:
                        Console.WriteLine(" ");
                        break;
                    default:
                        break;
                }

            } while (selection != 3);
        }
    }
}
