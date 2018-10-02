using Loja.Domain.ValueObjects;
using Loja.Shared.Commands;

namespace Loja.Domain.Commands.Inputs
{
    public class RegisterCustomerCommand:ICommand
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string PhoneNumber { get; set; }
        public string Number { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public string Email { get; set; }
    }
}
