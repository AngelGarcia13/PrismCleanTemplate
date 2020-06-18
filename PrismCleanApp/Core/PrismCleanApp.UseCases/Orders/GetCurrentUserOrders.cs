using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PrismCleanApp.Data.Orders;
using PrismCleanApp.Domain.Orders;

namespace PrismCleanApp.UseCases.Orders
{
    public class GetCurrentUserOrders
    {
        private OrdersRepository _ordersRepository;

        public GetCurrentUserOrders(OrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public Task<IReadOnlyList<Order>> Invoke()
        {
            return _ordersRepository.GetOrdersAsync();
        }
    }
}
