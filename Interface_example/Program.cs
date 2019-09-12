using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_example
{
    public interface ITransaction
    {
        void showTransaction();
        double getAmount();
    }
    public class Transaction : ITransaction
    {
        private string tCode;
        private string tDate;
        private double tAmount;
        public Transaction()
        {
            tCode = "";
            tDate = "";
            tAmount = 0.0;

        }
        public Transaction(string a, string b, double c)
        {
            tCode = a;
            tDate = b;
            tAmount = c;
        }
        public double getAmount()
        {
            return tAmount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Transaction:{0}", tCode);
            Console.WriteLine("Transaction date:{0}", tDate);
            Console.WriteLine("Transaction amount:{0}", tAmount);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("t001","09-09-2019",50000);
            Transaction t2 = new Transaction("t002", "11-09-2019", 60000);

            t1.showTransaction();
            Console.WriteLine("................................................");
            t2.showTransaction();
            Console.ReadLine();
        }
    }
}
