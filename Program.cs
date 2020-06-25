using System;

namespace MarketStore
{
    class Program
    {
        static void Main()
        {
            PaymentBureau bureau = new PaymentBureau();

            bureau.SetCard("Gold", 1500, 1300);

            Console.WriteLine(bureau.PaymentInfo());
        }
    }
}
