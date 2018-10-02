using Loja.Domain.Entities;
using Loja.Domain.Repositories;
using System;
using Dapper;

namespace Loja.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Edit(Product product)
        {
            throw new NotImplementedException();
        }

        public Guid Save(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
