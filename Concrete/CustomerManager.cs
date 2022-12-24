using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class CustomerManager : CustomerManagerBase, ICustomerService,ICustomerCheckService
    {
        

        ICustomerCheckService _customerCheckService;
        private CustomerCheckManager customerCheckManager;

        public CustomerManager()
        {
        }

        public CustomerManager(CustomerCheckManager customerCheckManager)
        {
            this.customerCheckManager = customerCheckManager;
        }

      

        public bool CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

        public override void delete(Customer customer)
        {
            Console.WriteLine("delete customer");
        }

        public override void update(Customer customer)
        {
            Console.WriteLine("update customer");
        }
    }
}
