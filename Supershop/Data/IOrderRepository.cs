using Supershop.Data.Entities;
using Supershop.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Supershop.Data
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<IQueryable<Order>> GetOrderAsync(string username);

        Task<IQueryable<OrderDetailTemp>> GetDetailTempsAsync(string username);

        Task AddItemToOrderAsync(AddItemViewModel model, string username);

        Task ModifyOrderDetailTempQuantityAsync(int id, double quantity);

        Task DeleteDetailTempAsync(int id);
    }
}
