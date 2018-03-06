using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }

        public static List<Data> GetAllData()
        {
            List<Data> listData = new List<Data>
            {
                new Data
                { Id = 1, Name = "AAA", Qty = 10, Price = 5},
                
                new Data
                { Id = 2, Name = "AAA", Qty = 5, Price = 6}
            };

            return listData;
        }
    }
}
