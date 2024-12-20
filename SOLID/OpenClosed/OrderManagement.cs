using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{

    //public enum LoyaltyCard
    //{
    //    Standard,
    //    Silver,
    //    Gold,
    //    Premium


    //}

    public abstract class LoyaltyCard
    {
        public abstract decimal GetDiscounted(decimal price);
      
    }

    public class StandardCard : LoyaltyCard
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * 0.95m;
        }
    }

    public class SilverCard : LoyaltyCard
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * 0.90m;
        }
    }

    public class GoldCard : LoyaltyCard
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * 0.85m;
        }
    }

    public class PremiumCard : LoyaltyCard
    {
        public override decimal GetDiscounted(decimal price)
        {
            return price * 0.80m;
        }
    }



    public class Customer
    {
        public string Name { get; set; }
        public LoyaltyCard LoyaltyCard { get; set; }

    }
    internal class OrderManagement
    {
        public Customer Customer { get; set; }
        public decimal GetDiscountedPrice(decimal price)
        {
            //switch (Customer.LoyaltyCard)
            //{
            //    case LoyaltyCard.Standard:
            //        return price * 0.95m;
            //    case LoyaltyCard.Silver:
            //        return price * 0.90m;
            //    case LoyaltyCard.Gold:
            //        return price * 0.85m;
            //    case LoyaltyCard.Premium:
            //    default:
            //        return price;
            //}

            return Customer.LoyaltyCard.GetDiscounted(price);
        }
    }
}
