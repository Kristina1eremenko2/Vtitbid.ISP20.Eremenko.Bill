using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Eremenko.Bill
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bill[] bills = Bill.Account();
            foreach (Bill bill in bills)
            {
                Console.WriteLine(bill);
            }
        }
    }
}
