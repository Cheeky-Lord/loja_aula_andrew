using System;
using Loja.Shared.Commands;

namespace Loja.Domain.Commands.Results
{
    class RegisterProductCommandResult:ICommandResult
    {
        public RegisterProductCommandResult()
        {
        }

        public RegisterProductCommandResult(Guid iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public Guid ID { get; private set; }
        public string Name { get; private set; }
    }
}
