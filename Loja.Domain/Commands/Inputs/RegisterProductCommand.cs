using Loja.Shared.Commands;

namespace Loja.Domain.Commands.Inputs
{
    class RegisterProductCommand : ICommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
