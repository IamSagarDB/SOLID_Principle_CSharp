using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.OCP
{
    class OCP_Bad
    {
        protected static void Main(string[] args)
        {

            var payment = new PaymentProcessor();
            payment.process(PaymentMode.UPI);
        }
    }

    /**
     * This Class Process the payment based on payment mode
     */
    class PaymentProcessor
    {
        public void process(PaymentMode paymentMode)
        {
            if (paymentMode == PaymentMode.CARD)
            {
                var cardPayment = new CardPayment();
                cardPayment.makePayment();
            }
            else if (paymentMode == PaymentMode.UPI)
            {
                var upiPayment = new UPIPayment();
                upiPayment.makePayment();
            }
        }
    }
    class CardPayment
    {
        public void makePayment()
        {
            Console.WriteLine("Card Payment done successfully");
        }
    }
    class UPIPayment
    {
        public void makePayment()
        {
            Console.WriteLine("UPI Payment done successfully");
        }
    }

    enum PaymentMode
    {
        CARD, UPI
    }




}
