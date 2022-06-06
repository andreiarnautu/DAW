using ProjectAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ProjectContext db;

        public AddressRepository(ProjectContext db)
        {
            this.db = db;
        }

        public void Create(Address address)
        {
            db.Addresses.Add(address);
            db.SaveChanges();
        }

        public IQueryable<Address> GetAddresses()
        {
            var addresses = db.Addresses;
            return addresses;
        }

        public void Update(Address address)
        {
            db.Addresses.Update(address);
            db.SaveChanges();
        }

        public void Delete(Address address)
        {
            db.Addresses.Remove(address);
            db.SaveChanges();
        }
    }
}
