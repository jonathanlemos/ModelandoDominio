
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    public class StudentTests
    {        
        //     //S = principio da responsábilidade única (cada classe tem uma unica tarefa ou seja faz uma unica coisa)
        //     //O = garante que apenas um método/função de dentro da classe poderá alterar os dados da propriedade

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var name = new Name("Bruce", "Wayne");
            var document = new Document("26162128032", EDocumentType.CPF);
            var email = new Email("Batman@dc.com");            
            var address = new Address("Rua 1", "1234", "bairro legal", "gothan", "RJ", "BR", "1234567");
            var student = new Student(name, document, email);
            var subscription = new Subscription(null);
            var payment = new PaypalPayment("1234567", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "WAYNE CORP", document, address, email);

            subscription.AddPayment(payment);
            student.AddSubscription(subscription);
            student.AddSubscription(subscription);
            
            Assert.Fail();
        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadSubscriptionHasNoPayment()
        {
            var name = new Name("Bruce", "Wayne");
            var document = new Document("26162128032", EDocumentType.CPF);
            var email = new Email("Batman@dc.com");            
            var student = new Student(name, document, email);

            

            Assert.Fail();
        }

        [TestMethod]
        public void ShouldReturnSucccessWhenHadActiveSubscription()
        {
            Assert.Fail();
        }
    }
}