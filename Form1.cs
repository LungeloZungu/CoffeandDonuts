using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeandDonuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Coffee;
            int Donuts;

            Coffee = int.Parse(txbCoffee.Text);
            Donuts = int.Parse(txbDonuts.Text);

            Order o = new Order(Coffee,Donuts);

            ProccessOrder proccess = new ProccessOrder();

            Cashier c = new Cashier();
            DonutService d = new DonutService();

            proccess.ProccessedOrder += c.CashierHandler;
            proccess.ProccessedOrder += d.DonutWorker;

            proccess.Proccess(o);
          
        }
    }
}
