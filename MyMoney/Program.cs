using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo MainDir = new DirectoryInfo("Data");
            MainDir.Create();
            StreamWriter sw= File.CreateText("Data\\money.txt");
            Console.WriteLine("Hello");
            sw.WriteLine("Hello");
            int debitsum = 0;
            int creditsum = 0;
            for(int i=0;i<10;i++)
            {
                string debit = "";
                Console.WriteLine("Enter Income");
                sw.WriteLine("Enter Income");
                debit = Console.ReadLine();
                sw.WriteLine(debit);
                int debitint = 0;
                int.TryParse(debit, out debitint);
                debitsum += debitint;
            }
            sw.WriteLine("total amount: {0}", debitsum);
            Console.WriteLine("total amount: {0}", debitsum);
            for (int i = 0; i < 10; i++)
            {
                string credit = "";
                Console.WriteLine("enter consumption");
                sw.WriteLine("enter consumption");
                credit = Console.ReadLine();
                sw.WriteLine(credit);
                int creditint = 0;
                int.TryParse(credit, out creditint);
                creditsum += creditint;
            }
            sw.WriteLine("total loss: {0}", creditsum);
            Console.WriteLine("total loss: {0}", creditsum);
            debitsum -= creditsum;
            Console.WriteLine("in your wallet: {0}", debitsum);
            sw.WriteLine("in your wallet: {0}", debitsum);
            sw.Close();
            Console.ReadKey();
        }
    }
}
