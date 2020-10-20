using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Subscription
    {
        public ISubscribeable Subscribeable { get; set; }
        public SubscriptionTypes SubscriptionTypes { get; set; }
    }
}
