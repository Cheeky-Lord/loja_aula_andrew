using FluentValidator;
using Loja.Domain.Enums;
using Loja.Domain.ValueObjects;
using Loja.Shared.Entities;
using System;

namespace Loja.Domain.Entities
{
    public class Costumer:Entity
    {

        public Costumer(string name, string cPF, string phoneNumber, Address address, Email email, EStatus status)
        {
            // Fail Fast Validation.
            if (Name.Length < 3)
                new Notification("Name", "O campo nome deve ter no mínimo 3 caracteres");
            AddNotifications(address.Notifications);
            AddNotifications(email.Notifications);

            if (cPF.Length != 11)
                new Notification("Document", "CPF inválido");
            
            Name = name;
            CPF = cPF;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
            Status = status;
        }

        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string PhoneNumber { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }
        public EStatus Status { get; private set; }

        public void ChangeStatus()
        {
            if (this.Status == EStatus.Enable)
                this.Status = EStatus.Disable;
            else
                this.Status = EStatus.Enable;
        }
    }
}
