using Loja.Shared.Entities;

namespace Loja.Domain.Entities
{
    public class Product:Entity
    {
        public Product(string description, double price)
        {
            Description = description;
            Price = price;
        }

        public string Description { get; private set; }
        public double Price { get; private set; }
    }
}
