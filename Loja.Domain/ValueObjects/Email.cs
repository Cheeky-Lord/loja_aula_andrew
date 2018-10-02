using FluentValidator;

namespace Loja.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;
            new ValidationContract<Email>(this)
                .IsEmail(X => X.Address, "Invalid email")
                .IsRequired(X => X.Address, "Email is required");
        }

        public string Address { get; private set; }
    }
}
