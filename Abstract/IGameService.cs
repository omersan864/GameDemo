using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public interface IGameService
    {
        void save(Game game);

        void delete(Game game);
        void update(Game game);
       
    }
}
