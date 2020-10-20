using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class RentableHandler
    {
        private static List<IRentable> rentables = new List<IRentable> { new Book() { Name = "It" }, new House() { Name = "FlorYMar" } };
        private static List<Subscription> subscriptions = new List<Subscription>();

        public static void AddItem(string itemName)
        {
            // rentables.Add(new Item() { Name = itemName });

            List<Subscription> subscriptionsToUpdate = subscriptions.Where(s => s.SubscriptionTypes == SubscriptionTypes.ITEMS).ToList();

            foreach (Subscription subscription in subscriptionsToUpdate)
            {
                subscription.Subscribeable.Update_X();
            }
        }

        public static List<IRentable> GetAllRentable()
        {
            return rentables;
        }

        public static void Subscribe(ISubscribeable subscriber, SubscriptionTypes subscriptionTypes)
        {
            subscriptions.Add(new Subscription() { Subscribeable = subscriber, SubscriptionTypes = subscriptionTypes });
            
        }
    }
}
