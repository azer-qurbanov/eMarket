using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using eMarket.Data.Entities;

namespace eMarket.Services
{
    public class TableServices
    {
        public void TableForProductList(List<Products> products)
        {
            var table = new ConsoleTable("No", "Ad", "Qiymət", "Say", "Umumi Qiymət", "Kod");

            foreach (var product in products)
            {
                table.AddRow(product.no, product.Name, product.Price.ToString("#.00"), product.Number,
                    (product.Price * product.Number).ToString("#.00"), product.Code);

            }

            table.Write();
            Console.WriteLine();
        }

        public void TableForSaleList(List<sale> Sales, List<saleitem> SaleItems)
        {

            var table = new ConsoleTable("No", "Məbləğ", "Tarix", "Məhsulun sayı");

            foreach (var sale in Sales)
            {
                table.AddRow(sale.no, sale.salePrice, sale.SaleDate, SaleItems.Where(s => s.Sale.no == sale.no).Sum(s => s.Number));
            }


            table.Write();
            Console.WriteLine();

        }
    }
}
