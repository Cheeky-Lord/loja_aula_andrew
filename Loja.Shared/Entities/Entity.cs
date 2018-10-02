using FluentValidator;
using System;

namespace Loja.Shared.Entities
{
    public abstract class Entity:Notifiable
    {
        public Entity()
        {
            ID = Guid.NewGuid();
        }

        public Guid ID { get; private set; }
    }
}
