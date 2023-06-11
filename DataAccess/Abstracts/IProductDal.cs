using DataAccess.Repository;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IProductDal : IEntityRepository<Products>
    {
        //custom operations
        //method overloading
        List<Products> GetAllWithCategory();
        List<Products> GetAllWithCategory(string productName);
    }
}
