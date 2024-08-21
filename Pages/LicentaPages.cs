using LicUiTests.Helpers;
using SeleniumExtras.PageObjects;

namespace LicUiTests.Pages
{
    public class LicentaPages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(WebDriver.Driver, page);
            return page;
        }
        public static LoginPage LoginPage => GetPage<LoginPage>();
        public static CompanyPage CompanyPage => GetPage<CompanyPage>();
        public static CommonPage CommonPage => GetPage<CommonPage>();
        public static WorkPointPage WorkPointPage => GetPage<WorkPointPage>();
        public static ProductsPage ProductsPage => GetPage<ProductsPage>();
        public static OrdersPage OrdersPage => GetPage<OrdersPage>();
        public static StockPage StockPage => GetPage<StockPage>();
        public static UsersPage UsersPage => GetPage<UsersPage>();
    }
}
