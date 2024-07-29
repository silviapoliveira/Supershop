using System.Linq;
using Supershop.Data.Entities;

namespace Supershop.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();
    }
}
