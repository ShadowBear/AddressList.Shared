using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressList.Shared.Models;

namespace AddressList.Shared.Services
{
    public interface IContactInfoService
    {
        Task<List<ContactInfo>> GetContactInfosAsync();
        Task<List<ContactInfo>> GetContactInfosByFileIdAsync(int fileId);
    }
}
