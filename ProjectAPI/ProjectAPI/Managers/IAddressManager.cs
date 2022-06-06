using ProjectAPI.Entities;
using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Managers
{
    public interface IAddressManager
    {
        void Create(AddressModel model);
        void Update(AddressModel model);
        List<Address> GetAddresses();
        Address GetAddressById(int id);
        void Delete(int id);
        List<Address> GetAddressesSorted();  
    }
}
