using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Service.Models;

namespace Service.Interface
{
    public interface IClientRepository
    {
        DataTable GetAllClients();
        bool SaveClientDetails(ClientDetail clientDetails);
        bool SaveClientContactDetails(ContactDetails ccontactDetails);
        bool SaveClientAddressDetails(AddressDetails addressDetails);
        DataTable GetClientAddressDetails(string clientId);
        DataTable GetClientContactDetails(string clientId);

    }
}
