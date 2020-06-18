using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PrismCleanApp.Data.Orders;
using PrismCleanApp.Domain.Orders;

namespace PrismCleanApp.Framework.DataSources
{
    public class InMemoryOrdersSource: IOrdersSource
    {
        public async Task<IReadOnlyList<Order>> GetAll()
        {
            await Task.Delay(1000);
            return new List<Order>
            {
                    
            };
        }
    }
}
