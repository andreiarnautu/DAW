using ProjectAPI.Entities;
using ProjectAPI.Models;
using ProjectAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Managers
{
    public class AddressManager : IAddressManager
    {
        private readonly IAddressRepository addressRepository;

        public AddressManager(IAddressRepository addressRepository)
        {
            this.addressRepository = addressRepository;
        }

        public void Create(AddressModel model)
        {
            var newAddress = new Address
            {
                AddressId = model.AddressId,
                AddressDetail = model.AddressDetail
            };

            addressRepository.Create(newAddress);
        }

        public void Update(AddressModel model)
        {
            var newAddress = GetAddressById(model.AddressId);
            newAddress.AddressId = model.AddressId;
            newAddress.AddressDetail = model.AddressDetail;

            addressRepository.Update(newAddress);
        }

        public List<Address> GetAddresses()
        {
            return addressRepository.GetAddresses().ToList();
        }

        public Address GetAddressById(int id)
        {
            var address = addressRepository
                .GetAddresses()
                .Where(address => address.AddressId == id)
                .FirstOrDefault();
            return address;
        }

        public void Delete(int id)
        {
            var address = GetAddressById(id);
            addressRepository.Delete(address);
        }

        public List<Address> GetAddressesSorted()
        {
            return addressRepository.GetAddresses()
                .OrderBy(x => x.AddressDetail)
                .ToList();
        }
    }
}
