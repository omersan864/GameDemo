using GameDemo.Abstract;
using GameDemo.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Adapters
{
    public class MernisServiceAdapter : IcustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient Client = new KPSPublicSoapClient();
            return Client.TCKimlikNoDogrula(Convert.ToInt64(customer.NatinonalityId),
                                            customer.Name.ToUpper(),
                                            customer.LastName.ToUpper(),
                                            customer.DateOfBirth.Year);

            //return Client.TCKimlikNoDogrulaAsync()

        }
    }
}
