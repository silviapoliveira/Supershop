using Supershop.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Supershop.Data
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrderAsync(string username);

        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string username);
    }
}
