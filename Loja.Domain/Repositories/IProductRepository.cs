using Loja.Domain.Entities;
using System;

namespace Loja.Domain.Repositories
{
    public interface IProductRepository
    {
        Guid Save(Product product);
        void Delete(Product product);
        void Edit(Product product);
    }
}
