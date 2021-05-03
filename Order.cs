using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeandDonuts
{
    class Order
    {

        
        private int coffee;
        private int dounuts;

        public Order( int coffee, int dounuts)
        {
            this.Coffee = coffee;
            this.Dounuts = dounuts;
        }

        
        public int Coffee { get => coffee; set => coffee = value; }
        public int Dounuts { get => dounuts; set => dounuts = value; }

        public double calculate()
        {
            return (this.dounuts * 12) + (this.coffee * 15);
        }
    }
}
