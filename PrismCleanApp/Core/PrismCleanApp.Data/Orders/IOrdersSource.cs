using System.Collections.Generic;
using System.Threading.Tasks;
using PrismCleanApp.Domain.Orders;

namespace PrismCleanApp.Data.Orders
{
    public interface IOrdersSource
    {
        Task<IReadOnlyList<Order>> GetAll();
    }
}