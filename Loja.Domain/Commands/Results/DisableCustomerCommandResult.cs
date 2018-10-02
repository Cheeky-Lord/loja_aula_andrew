using System;
using Loja.Shared.Commands;

namespace Loja.Domain.Commands.Results
{
    class DisableCustomerCommandResult : ICommandResult
    {
        public DisableCustomerCommandResult()
        {

        }

        public DisableCustomerCommandResult(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}
