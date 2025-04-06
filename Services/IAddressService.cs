using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressList.Shared.Models;

namespace AddressList.Shared.Services
{
    public interface IAddressService
    {
        Task<List<Address>> GetAddressesAsync();
        Task<List<Address>> SearchAddressesAsync(string aktenzeichen);
        Task<bool> SaveAddress(Address address);
        Task ClearAddressData();
    }
}
