using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private readonly ICollection<GiftBase> gifts; 

        public CompositeGift(string name, int price) 
            : base(name, price)
        {
            gifts = new HashSet<GiftBase>();    
        }

        public void Add(GiftBase gift)
        {
            gifts.Add(gift); 
        }
        public void Remove(GiftBase gift)
        {
            gifts.Remove(gift);
        }

        public override int CalculateTotalPrice()
        {
            int total = 0;

            Console.WriteLine($"{name} contains the following pieces:");

            foreach (var gift in gifts)
            {
                total += gift.CalculateTotalPrice();
            }
            return total;
        }

    }
}
