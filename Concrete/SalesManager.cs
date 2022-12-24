using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class SalesManager : ISalesService
    {
        public void sales(Customer customer, Game game)
        {
            Console.WriteLine("satış yapılmıştır" +customer.Name,game.GameName);
        }
    }
}
