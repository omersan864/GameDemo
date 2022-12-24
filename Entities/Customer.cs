using System;
using GameDemo.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GameDemo.Entities
{
    public class Customer : IEntityService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string NatinonalityId { get; set; }


    }
}
