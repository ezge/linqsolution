using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Data.GetAllData().GroupBy(x => new { x.Name })
                                          .Select(x => new
                                                        {
                                                            Id = 0,
                                                            Name = x.Key.Name,
                                                            Sum = x.Sum(y => y.Qty),
                                                            Avg = x.Average(z => z.Price)
                                                        });

            foreach (var item in result)
            {
                Console.WriteLine("{{{0}, \"{1}\", {2}, {3:0.##}}}", item.Id, item.Name, item.Sum, item.Avg);
            }

            Console.ReadKey();
        }
    }
}
