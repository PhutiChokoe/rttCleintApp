using System;
using System.Collections.Generic;
using RttClient.ClientService;



namespace RttClient
{
    public interface IServiceHandler
    {
        List<ClientDetail> GetAllClients();
        bool SaveClientData(ClientDetail clientDetails);
        bool SaveAddressData(AddressDetails addressDetails);
        bool SaveContactData(ContactDetails contactDetails);
        List<AddressDetails> GetAllAddressDetails(string clientId);
        List<ContactDetails> GetAllContactDetails(string clientId);
    }
}
