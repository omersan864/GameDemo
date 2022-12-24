using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    public class Campaign: IEntityService
    {
        public int CampainId { get; set; }
        public string CampainName { get;  set; }
        public string CampainDescription { get; set; }

    }
}
