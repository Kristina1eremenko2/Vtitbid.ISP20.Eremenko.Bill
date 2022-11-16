using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Eremenko.Bill
{
    public class Bill
    {
        public string Payer { get; set; }
        public string Recipient { get; set; }
        public string Amount { get; set; }
        public Bill(string payer, string recipient, string amount)
        {
            Payer = payer;
            Recipient = recipient;
            Amount = amount;
        }
        public static Bill[] Account()
        {
            int numberOfPeople = 0;
            string input;
            do
            {
                Console.Write("Введите количество людей: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out numberOfPeople));

            Bill[] bill = new Bill[numberOfPeople];
            for (int i = 0; i < bill.Length; i++)
            {
                Console.WriteLine("Введите расчетный счет плательщика: ");
                string payer = Console.ReadLine();
                Console.WriteLine("Введите расчетный счет получателя: ");
                string recipient = Console.ReadLine();
                Console.WriteLine("Введите перечисляемую сумму в рублях: ");
                string amount = Console.ReadLine();
                bill[i] = new Bill(payer, recipient,amount);
            }
            Bill[] billSort = bill.OrderBy(ob => ob.Payer).ToArray();
            for (int i = 0; i < bill.Length; i++)
            {
                Console.WriteLine(billSort[i]);
            }
            Console.WriteLine("Поиск по расчетному счету платильщика: ");
            string ser = Console.ReadLine();

            for (int i = 0; i < billSort.Length; i++)
            {
                if (ser.ToLower() == bill[i].Payer.ToLower())
                {
                    Console.WriteLine(bill[i]);
                }
                else if (ser.ToLower() != bill[i].Payer.ToLower() && i == bill.Length - 1)
                {
                    Console.WriteLine("Такого расчетного счета нет!!!");
                }
            }
            Console.ReadKey();
            return bill;
        }
        public override string ToString()
        {
            return $"Расчетный счет плательщика: {Payer}\n Расчетный счет получателя: {Recipient}\n Перечисляемая сумма в рублях: {Amount} ";
        }
    }
}
