using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void delete(Campaign campaign)
        {
            Console.WriteLine("campain delete");
        }

        public void save(Campaign campaign)
        {
            Console.WriteLine("campain save");
        }

        public void update(Campaign campaign)
        {
            Console.WriteLine("campain update");
        }
    }
}
