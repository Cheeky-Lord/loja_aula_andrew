using FluentValidator;

namespace Loja.Domain.ValueObjects
{
    public class Address : Notifiable
    {
        public Address(string number, string street, string city, string country, string zipCode)
        {
            Number = number;
            Street = street;
            City = city;
            Country = country;
            ZipCode = zipCode;
        }

        public string Number { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
    }
}
