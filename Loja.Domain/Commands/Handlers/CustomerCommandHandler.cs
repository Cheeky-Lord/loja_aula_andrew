using FluentValidator;
using Loja.Domain.Commands.Inputs;
using Loja.Shared.Commands;
using Loja.Domain.Entities;
using Loja.Domain.ValueObjects;
using Loja.Domain.Commands.Results;
using Loja.Domain.Repositories;

namespace Loja.Domain.Commands.Handlers
{
    public class CustomerCommandHandler : Notifiable, ICommandHandler<RegisterCustomerCommand>
    {
        private readonly ICustomerRepository customerRepository;
        public ICommandResult Handle(RegisterCustomerCommand Command)
        {
            var address = new Address(
                Command.Number,
                Command.Street,
                Command.City,
                Command.Country,
                Command.ZipCode
            );

            var email = new Email(
                Command.Email
            );

            var customer = new Costumer(
                Command.Name,
                Command.CPF,
                Command.PhoneNumber,
                address,
                email,
                Enums.EStatus.Enable
            );

            AddNotifications(customer.Notifications);
            AddNotifications(address.Notifications);
            AddNotifications(email.Notifications);

            //1- Verificar se o e-mail já está em uso.

            customerRepository.EmailExists(customer.Email);

            //2- Verificar se o CPF já está cadastrado.

            customerRepository.DocumentExists(customer.CPF);

            if (!IsValid())
                return null;

            //3- Persistir no banco.

            customerRepository.Register(customer);

            //4- Enviar e-mail de confirmação.
            //5- Retornar o CommandResult apropriado.

            return new RegisterCostumerCommandResult(customer.ID, customer.Name);
        }
    }
}
