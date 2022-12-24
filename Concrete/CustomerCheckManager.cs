using GameDemo.Abstract;
using GameDemo.Adapters;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class CustomerCheckManager : IcustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
