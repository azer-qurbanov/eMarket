using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.Data.Common;

namespace eMarket.Data.Entities
{
    public class saleitem : BaseEntity
    {
        private static int count = 0;

        public Products ProductCode { get; set; }


        public sale Sale { get; set; }

        public int Number { get; set; }

        public double Price { get; set; }




        public saleitem()
        {
            count++;

            no = count;
        }
    }
}
