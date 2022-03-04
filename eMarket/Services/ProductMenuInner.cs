using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.Data.Entities;

namespace eMarket.Services
{
    public class ProductMenuInner
    {
        private static TableServices tableServices = new TableServices();
        MarketServices ms = new MarketServices();

        public static void ap()
        {

            Console.WriteLine("Mehsulun adini daxil et");
            string name = Console.ReadLine();
            Console.WriteLine("Mehsulun qiymetini daxil et");
            string price = Console.ReadLine();
            Console.WriteLine("Mehsulun sayini daxil et");
            string number = Console.ReadLine();
            Console.WriteLine("Mehsulun kodunu daxil et");
            string code = Console.ReadLine();
        }
        public static void DP()
        {
            Console.WriteLine("Mehsulun kodunu daxil et");
            string code = Console.ReadLine();
        }
        public static void EP()
        {
            Console.WriteLine("Məhsulun kodunu daxil edin");
            string oldCode = Console.ReadLine();

            List<Products> products = MarketServices.products.Where(p => p.Code == oldCode).ToList();

            tableServices.TableForProductList(products);

            Console.WriteLine("Məhsulun adını daxil edin");
            string newName = Console.ReadLine();

            Console.WriteLine("Məhsulun qiymətini daxil edin");
            string newPrice = Console.ReadLine();

            Console.WriteLine("Məhsulun sayınısı daxil edin");
            string newQuantity = Console.ReadLine();

            Console.WriteLine("Məhsulun kodunu daxil edin");
            string newCode = Console.ReadLine();
            Console.WriteLine("Məhsul redakte edildi");
        }
        public static void AllInfo()
        {
            tableServices.TableForProductList(MarketServices.products);
        }

        public static void ProductsPriceRange()
        {
            Console.WriteLine("Qiymet aralığını daxil edin");

            Console.WriteLine("Min məbləğ");
            double minPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Max məbləğ");
            double maxPrice = double.Parse(Console.ReadLine());

            if (minPrice > maxPrice)
            {
                Console.WriteLine("Məbləğ aralığı düzgün deyil");
            }

            List<Products> products = MarketServices.products.FindAll(p => p.Price >= minPrice && p.Price <= maxPrice);

            tableServices.TableForProductList(products);

        }

        public static void ProductsName() 
        {
            Console.WriteLine("Məhsulun adını daxil edin");
            string name = Console.ReadLine();
            List<Products> products =
                MarketServices.products.FindAll(p => p.Name.ToLower().Contains(name.ToLower()));
            tableServices.TableForProductList(products);

        }


    }
}
