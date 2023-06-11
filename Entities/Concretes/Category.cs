using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//domain objects
namespace Entities.Concretes
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Products> Products { get; set; }
    }
}
