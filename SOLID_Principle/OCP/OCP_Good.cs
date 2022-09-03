using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.OCP
{
    class OCP_Good
    {
        protected static void Main(string[] args)
        {
            PaymentProcess payment = new PaymentProcess();
            payment.process(new UPIPaymentA());
        }
    }

    class PaymentProcess
    {
        public void process(IPay pay)
        {
            pay.makePayment();
        }
    }

    interface IPay
    {
        void makePayment();
    }

    class CardPaymentA : IPay { 
        
        public void makePayment()
        {
            Console.WriteLine("Card Payment Done");
        }
    }

    class UPIPaymentA : IPay
    {
        public void makePayment()
        {
            Console.WriteLine("UPI Payment Done");
        }
    }
}
