
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    public class DocumentTests
    {
        [TestMethod]                   
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Document("8664391086", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]                   
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var doc = new Document("86643914086", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);            
        }

        [TestMethod]                   
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var doc = new Document("866439140", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("86643914086")]
        [DataRow("5484755098")]
        [DataRow("74390226029")]        
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}