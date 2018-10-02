using Loja.Domain.Enums;
using Loja.Shared.Commands;

namespace Loja.Domain.Commands.Inputs
{
    class DisableCustomerCommand : ICommand
    {
        public EStatus Disable { get; private set; }
    }
}
