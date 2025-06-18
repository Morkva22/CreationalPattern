using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Observer
{
    enum PlatformType
    {
        Email,
        Sms,
        Push
    }
    public class ClientCode
    {
        public void Main()
        {
            Customer<string> customer1 = new Customer<string>("John Doe");
            Customer<string> customer2 = new Customer<string>("Jane Smith");
            Customer<string> customer3 = new Customer<string>("Mike Johnson");
            Customer<string> customer4 = new Customer<string>("Sarah Wilson");
            Customer<string> customer5 = new Customer<string>("Tom Brown");

            Shop<string> shop1 = new Shop<string>("Tech Store");
            Shop<string> shop2 = new Shop<string>("Fashion Shop");
            Shop<string> shop3 = new Shop<string>("Book Store");
            Shop<string> shop4 = new Shop<string>("Music Store");
            Shop<string> shop5 = new Shop<string>("Game Store");

            Dictionary<PlatformType, NotificationPlatform<string>> platforms = new Dictionary<PlatformType, NotificationPlatform<string>>()
            {
                { PlatformType.Email, new NotificationPlatform<string>("Email")},
                { PlatformType.Sms, new NotificationPlatform<string>("SMS")},
                { PlatformType.Push, new NotificationPlatform<string>("Push")}
            };

            platforms[PlatformType.Email].AddShop(shop1);
            platforms[PlatformType.Email].AddShop(shop2);
            platforms[PlatformType.Email].AddShop(shop3);
            platforms[PlatformType.Email].AddShop(shop4);
            platforms[PlatformType.Email].AddShop(shop5);

            platforms[PlatformType.Sms].AddShop(shop1);
            platforms[PlatformType.Sms].AddShop(shop4);
            platforms[PlatformType.Sms].AddShop(shop5);

            platforms[PlatformType.Push].AddShop(shop5);

            platforms[PlatformType.Email].AddCustomerToShops(customer1);
            platforms[PlatformType.Email].AddCustomerToShops(customer2);
            platforms[PlatformType.Email].AddCustomerToShops(customer3);
            platforms[PlatformType.Email].AddCustomerToShops(customer4);
            platforms[PlatformType.Email].AddCustomerToShops(customer5);

            platforms[PlatformType.Sms].AddCustomerToShops(customer1);
            platforms[PlatformType.Sms].AddCustomerToShops(customer4);
            platforms[PlatformType.Sms].AddCustomerToShops(customer5);

            platforms[PlatformType.Push].AddCustomerToShop(customer5, "Game Store");
            platforms[PlatformType.Push].AddCustomerToShop(customer1, "Game Store");
            platforms[PlatformType.Push].AddCustomerToShop(customer2, "Game Store");

            platforms[PlatformType.Email].NotifyShop("New laptop available", "Tech Store");
            platforms[PlatformType.Email].NotifyShop("New dress collection", "Fashion Shop");
            platforms[PlatformType.Email].NotifyShop("New bestseller arrived", "Book Store");

            platforms[PlatformType.Sms].NotifyShop("Laptop discount 50%", "Tech Store");
            platforms[PlatformType.Sms].NotifyShop("New album released", "Music Store");
            platforms[PlatformType.Sms].NotifyShop("Game sale started", "Game Store");

            platforms[PlatformType.Push].NotifyShop("New AAA game available", "Game Store");

            platforms[PlatformType.Email].RemoveCustomerFromShop(customer2, "Tech Store");
            platforms[PlatformType.Email].RemoveCustomerFromShop(customer3, "Tech Store");

            platforms[PlatformType.Email].NotifyShop("Premium laptop models", "Tech Store");
        }
    }
}