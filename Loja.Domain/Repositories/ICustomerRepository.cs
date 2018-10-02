using Loja.Domain.ValueObjects;
using Loja.Domain.Entities;
using System;

namespace Loja.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Guid Register(Costumer customer);

        // Implementar metodo e notification.
        void Disable(Costumer customer);

        // Implementar metodo e notification.
        bool DocumentExists(string document);

        // Implementar metodo e notification.
        bool EmailExists(Email email);
    }
}
