using System;
using System.Collections.Generic;
using System.Linq;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;

        public Student(Name name, Document document, Email email)
        {
            this.Name = name;
            this.Document = document;
            this.Email = email;
            _subscriptions = new List<Subscription>();
            

            AddNotifications(name, document, email);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        public void AddSubscription (Subscription subscription) 
        {
            //Se já tiver uma assinatura ativa, cancela
            //Cancela todas as outras assinaturas, e coloca esta
            //como principal

            foreach(var sub in _subscriptions)
            {
                //if(sub.Active)
                    //hasSubscriptionActive = true;
            }

            // AddNotification(new ContextMarshalException() 
            // .Requires()
            // .IsFalse(hasSubscriptionActive, "Student.Subscription", "Você já tem uma assinatura ativa")
            // .IsGreaterThan(0, subscription.Payments.Count, "Studen.Subscription.Payments", "Essa assinautra não possui pagamentos.")
            // );

            _subscriptions.Add(subscription);
        }
    }
}