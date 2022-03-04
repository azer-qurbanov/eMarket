using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.Data.Common;

namespace eMarket.Data.Entities
{
    public class sale: BaseEntity
    {
        public double salePrice { get; set; }
        public DateTime SaleDate { get; set; }
        private static int count = 0;
        public sale()
        {
            count++;
            no = count;
            SaleDate = DateTime.Now;
        }
    }
}
