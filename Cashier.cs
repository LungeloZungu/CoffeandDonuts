using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CoffeandDonuts
{
    class Cashier
    {
        public void CashierHandler(Order o , EventArgs e)
        {
            MessageBox.Show("Collect Cash");
        }
    }
}
