using System;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PrismCleanApp.Data.Orders;
using PrismCleanApp.Framework.DataSources;
using PrismCleanApp.UI.Orders.ViewModels;
using PrismCleanApp.UI.Orders.Views;
using PrismCleanApp.UseCases.Orders;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PrismCleanApp
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.Register<OrdersRepository>();
            containerRegistry.Register<IOrdersSource, InMemoryOrdersSource>();
            containerRegistry.Register<GetCurrentUserOrders>();
        }
    }
}
