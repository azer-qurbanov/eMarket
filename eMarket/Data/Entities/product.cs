using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eMarket.Data.Common;

namespace eMarket.Data.Entities
{
    public class Products: BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public string Code { get; set; }

        private static int count = 0;
        public Products()
        {
            count++;
            no = count;
        }

        internal static int FindIndex(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
