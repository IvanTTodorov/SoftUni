using System;
using System.Collections.Generic;
using System.Text;

namespace FoodStortage
{
    public interface IIdentifiable
    {
        public int Food { get; set; }
        int BuyFood();

    }
}
