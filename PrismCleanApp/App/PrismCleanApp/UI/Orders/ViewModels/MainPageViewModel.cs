using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismCleanApp.Domain.Orders;
using PrismCleanApp.UI.ViewModels;
using PrismCleanApp.UseCases.Orders;

namespace PrismCleanApp.UI.Orders.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<Order> Orders { get; set; }
        private readonly GetCurrentUserOrders _getCurrentUserOrders;
        public MainPageViewModel(INavigationService navigationService, GetCurrentUserOrders getCurrentUserOrders)
            : base(navigationService)
        {
            _getCurrentUserOrders = getCurrentUserOrders;
            Title = "Main Page";
            Orders = new ObservableCollection<Order>();
            LoadOrders();
        }

        private async void LoadOrders()
        {
            var resultOrders = await _getCurrentUserOrders.Invoke();
            foreach (var item in resultOrders)
            {
                Orders.Add(item);
            }
        }
    }
}