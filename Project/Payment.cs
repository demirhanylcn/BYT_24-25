﻿namespace Project
{
    public class Payment
    {
        private static int _lastPaymentId = 0;

        public int OrderId { get; set; }
        public int PaymentId { get; set; }
        public string PaymentMethod { get; set; }
        public double Amount { get; set; }

        public Payment(int orderId, string paymentMethod, double amount)
        {
            OrderId = orderId;
            PaymentMethod = paymentMethod;
            Amount = amount;
            PaymentId = _lastPaymentId++;
        }

        public override string ToString()
        {
            return "Payment id: " + PaymentId + " Order id: " + OrderId + " Amount " + Amount; 
        }
    }

}

