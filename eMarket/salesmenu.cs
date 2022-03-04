using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.Services;

namespace eMarket
{
    public class salesmenu
    {
        public static void SalesMenu()
        {
            int selection = 0;

            do
            {
                Console.WriteLine("1. Yeni satış əlavə et");
                Console.WriteLine("2. Staışın anbara qayıtması");
                Console.WriteLine("3. Satışın silinməsi");
                Console.WriteLine("4. Satışların siyahısı");
                Console.WriteLine("5. Tarix aralığına görə satışlar");
                Console.WriteLine("6. Satış qiyməti aralığına görə satışlar");
                Console.WriteLine("7. Verilmiş tarixdəki satışlar");
                Console.WriteLine("8. Satış nömrəsinə görə axtarış");
                Console.WriteLine("9. Ana səhifəyə qayıt");

                Console.WriteLine("Please select your option");

                string selectionStr = Console.ReadLine();
                selection = int.Parse(selectionStr);


                switch (selection)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        Program.MainMenu();
                        break;
                    default:
                        break;
                }

            } while (selection != 9);
        }
    }
}
