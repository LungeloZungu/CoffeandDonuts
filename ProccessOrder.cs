using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeandDonuts
{
    class ProccessOrder
    {
        public delegate void ProccessOrderEvent(Order source, EventArgs e);

        public event ProccessOrderEvent ProccessedOrder;

        public void Proccess(Order o)
        {
            OnProccessedOrder(o);
        }

        public virtual void OnProccessedOrder(Order o)
        {
            if (ProccessedOrder != null)
            {
                ProccessedOrder(o, EventArgs.Empty);
            }
        }
    }
}
