using GameDemo.Abstract;
using GameDemo.Entities;

namespace GameDemo.Concrete
{
    public abstract class CustomerManagerBase : ICustomerService
    {
        public abstract void delete(Customer customer);
        public virtual void save(Customer customer)
        {
            Console.WriteLine("db ye kayıt");
        }
        public abstract void update(Customer customer);
    }
}