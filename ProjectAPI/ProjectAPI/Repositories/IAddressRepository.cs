using ProjectAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Repositories
{
    public interface IAddressRepository
    {
        void Create(Address address);
        void Update(Address address);
        void Delete(Address address);
        IQueryable<Address> GetAddresses();
    }
}
