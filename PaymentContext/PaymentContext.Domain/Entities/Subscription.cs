using System;
using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        private IList<Payment> _payments;

        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            ActiveSub = true;

            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool ActiveSub { get; set; }
        public IReadOnlyCollection<Payment> Payments { get{ return _payments.ToArray() ; } }

        public void AddPayment(Payment payment)
        {
            _payments.Add(payment);
        }

        public void Active () 
        {  
            ActiveSub = true;
            LastUpdateDate = DateTime.Now;

        }

        public void Inactivate () 
        {  
            ActiveSub = false;
            LastUpdateDate = DateTime.Now;

        }
    }
}