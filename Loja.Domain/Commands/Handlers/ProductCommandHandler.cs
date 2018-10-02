using FluentValidator;
using Loja.Domain.Commands.Inputs;
using Loja.Shared.Commands;
using Loja.Domain.Entities;
using Loja.Domain.Commands.Results;

namespace Loja.Domain.Commands.Handlers
{
    class ProductCommandHandler : Notifiable, ICommandHandler<RegisterProductCommand>
    {
        public ICommandResult Handle(RegisterProductCommand Command)
        {
            var product = new Product(
                Command.Description,
                Command.Price
            );

            return new RegisterProductCommandResult(product.ID, product.Description);
        }
    }
}
