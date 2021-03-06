using PaymentContext.Shared.ValueObjects;
using Flunt.Notifications;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
 
             if(string.IsNullOrEmpty(FirstName))
                 AddNotification("Name.FirstName", "Nome Inválido.");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}


