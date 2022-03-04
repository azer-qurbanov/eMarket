using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.Services;

namespace eMarket
{
    public class productmenu
    {

        public static void Productmenu()
            
        {
            MarketServices marketServices = new MarketServices();
            int selection = 0;
            do
            {
                Console.WriteLine("1. Yeni mehsul elave et");
                Console.WriteLine("2. Mehsulu redakte et");
                Console.WriteLine("3. Mehsulu sil");
                Console.WriteLine("4. Butun mehsullar");
                Console.WriteLine("5. Qiymet aralığına görə mehsullar");
                Console.WriteLine("6. Ada göre axtariş");
                Console.WriteLine("7. Ana səhifeyə qayit");
                Console.WriteLine("Zehmet olmasa menudan seçim edin");

                string selectionStr = Console.ReadLine();
                selection = int.Parse(selectionStr);

                switch (selection)
                {
                    case 1:
                        ProductMenuInner.ap();
                        break;
                    case 2:
                        ProductMenuInner.EP();
                        break;
                    case 3:
                        ProductMenuInner.DP();
                        break;
                    case 4:
                        ProductMenuInner.AllInfo();
                        break;
                    case 5:
                        ProductMenuInner.ProductsPriceRange();
                        break;
                    case 6:
                        ProductMenuInner.ProductsName();
                        break;
                    case 7:
                        Program.MainMenu();
                        break;
                    default:
                        break;
                }

            } while (selection != 7);
        }
           
        }
    }

