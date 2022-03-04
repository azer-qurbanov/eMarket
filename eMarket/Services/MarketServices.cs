using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using eMarket.Data.Entities;

namespace eMarket.Services
{
    public class MarketServices
    {
        public static List<Products> products { get; private set; }
        public static List<sale> Sales { get; private set; }
        public static List<saleitem> SaleItems { get; private set; }
        public  MarketServices()
        {
            products = new List<Products>();
            Sales = new List<sale>();
            SaleItems = new List<saleitem>();
        }
        #region Product
        public int AddProduct(string name, double price, int number, string code)
        {

            Products product = new Products();
            product.Name = name;
            product.Price = price;
            product.Code = code;

            products.Add(product);
            return product.no;
        }
        public int EditProduct(string newName, double newPrice, int newQuantity, string newCode, string oldCode)
        {

            Products product = products.FirstOrDefault(p => p.Code == oldCode);

            product.Name = newName;
            product.Price = newPrice;
            product.Number = newQuantity;
            product.Code = newCode;

            return product.no;



        }

        public void DeleteProduct(string code)
        {

            int index = products.FindIndex(d => d.Code == code);
            if (index == -1)
                throw new KeyNotFoundException();

            products.RemoveAt(index);

        }
        #endregion
        #region Sale
        public sale AddSale(DateTime date)
        {
            sale Sale = new sale()
            {
                SaleDate = date,
                salePrice = 0
            };
            Sales.Add(Sale);

            return Sale;
        }
        public int AddSaleItem(Products product, int number, double price, sale Sale)
        {

           

            saleitem SaleItem =  new saleitem();

            SaleItem.ProductCode = product;
            SaleItem.Number = number;
            SaleItem.Price = price;
            SaleItem.Sale = Sale;
            Sale.salePrice += (price * number);
            product.Number -= number;

            SaleItems.Add(SaleItem);


            return product.no;
        }
        public void DeleteSale(int No)
        {

            int sale = Sales.FindIndex(s => s.no == No);

            var saleItems = SaleItems.Where(s => s.Sale.no == No).ToList();

            foreach (var salesItem in SaleItems)
            {
                var product = products.FirstOrDefault(p => p.Code == salesItem.ProductCode.Code);

                product.Number += salesItem.Number;

            }
            Sales.RemoveAt(sale);
        }
        #endregion
        #region Info
       
        public int TimeSaleinfo(DateTime startDate, DateTime stopDate)
        {
        var TimeSales = Sales.Where(m => m.SaleDate >= startDate && m.SaleDate <= stopDate);
        int tm = TimeSales.Count();
        Console.WriteLine(tm);
            return tm;
        }
        #endregion
    }
}
    
        
    

