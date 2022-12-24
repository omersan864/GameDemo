using GameDemo.Abstract;
using GameDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Entities
{
    public class Game:IEntityService
    {
        public int IdGame { get; set; }
        public string GameName { get; set; }
        public string GameVersion { get; set; }

        
    }
}
