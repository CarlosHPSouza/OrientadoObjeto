using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cobrança
{
    class Guy
    {
        public string Name;
        public int Cash;

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + "isn t an amount i ll take", Name + "says...");
                return 0;
            }
        }

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("I dont have enought cash to give  you " + amount, Name + " says....");
                return 0;
            }
            
           
        }
    }
}
