using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Supershop.Data.Entities;

namespace Supershop.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public IQueryable GetAllWithUsers();

        public IEnumerable<SelectListItem> GetComboProducts();
    }
}
