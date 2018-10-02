using System;
using Loja.Shared.Commands;

namespace Loja.Domain.Commands.Results
{
    public class RegisterCostumerCommandResult:ICommandResult
    {
        public RegisterCostumerCommandResult()
        {

        }

        public RegisterCostumerCommandResult(Guid iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public Guid ID { get; private set; }
        public string Name { get; private set; }
    }
}
