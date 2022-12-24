using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void delete(Game game)
        {
            Console.WriteLine("game delete"); ;
        }

        public void save(Game game)
        {
            Console.WriteLine("game save");
        }

        public void update(Game game)
        {
            Console.WriteLine("game update");
        }
    }
}
