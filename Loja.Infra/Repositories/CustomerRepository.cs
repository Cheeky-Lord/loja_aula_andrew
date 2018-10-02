using Loja.Domain.Entities;
using Loja.Domain.Repositories;
using Loja.Domain.ValueObjects;
using System;
using Dapper;
using Loja.Infra.DB;

namespace Loja.Infra.Repositories
{
    class CustomerRepository : ICustomerRepository
    {
        private IDB _DB;
        public CustomerRepository(IDB db)
        {
            _DB = db;
        }

        public void Disable(Costumer customer)
        {
            customer.ChangeStatus();
            var sql = "update customer set Status = @status, "
                + "ID = @id, "
                + "Name = @nome, "
                + "Birthday = @birthday"
                + "Street = @street"
                + "Number = @number"
                + "City = @city"
                + "State = @state"
                + "Country = @country"
                + "ZipCode = @zipcode"
                + "Document = @document"
                + "EmailAdress = @emailaddress";
            using (var con = _DB.GetConnection())
            {
                con.Execute(sql, customer);
            }
        }

        public bool DocumentExists(string document)
        {
            using (var db = _DB.GetConnection())
            {
                var count = db.Query("select Document from customer where Document = @document"
                    , new { }).AsList().Count;

                if (count > 0)
                    return true;
                return false;
            }
        }

        public bool EmailExists(Email email)
        {
            using (var db = _DB.GetConnection())
            {
                var count = db.Query("select EmailAdress from customer where Document = @document"
                    , new { }).AsList().Count;

                if (count > 0)
                    return true;
                return false;
            }
        }

        public Guid Register(Costumer customer)
        {
            var sql = "insert into [dbo].[customer] ([ID], [name], [Birthday], [Street], [Number], [City], [State], [Country], [ZipCode], [Document], [EmailAdress], [Status]) values (@ID, @name, @birthday, @street, @number, @city, @state, @country, @zipcode, @document, @emailaddress, @state)";
            using (var con = _DB.GetConnection())
            {
                con.Execute(sql, new { ID = customer.ID,
                    nome = customer.Name,
                    status = customer.Status,
                    address = customer.Address.Street
                });
            }

            return customer.ID;
        }
    }
}
