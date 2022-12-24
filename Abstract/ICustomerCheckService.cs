using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
        void save(Customer customer);
    }
}
