using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RttClient.ClientService;
using Service;
using Service.Models;
using AddressDetails = RttClient.ClientService.AddressDetails;
using ClientDetail = RttClient.ClientService.ClientDetail;
using ContactDetails = RttClient.ClientService.ContactDetails;


namespace RttClient
{
    public class ServiceHandler : IServiceHandler
    {
        private readonly ClientService.DataServiceSoapClient _client = new DataServiceSoapClient();
        private readonly RttLogger _rttLogger = new RttLogger();

        public List<AddressDetails> GetAllAddressDetails(string clientId)
        {
            try
            {
                return _client.GetAddressDetails(clientId).ToList();
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }

        public List<ClientDetail> GetAllClients()
        {
            try
            {
                return _client.GetAllClients().ToList();

            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }

        public List<ContactDetails> GetAllContactDetails(string clientId)
        {
            try
            {
                return _client.GetContactDetails(clientId).ToList();
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }

        }

        public bool SaveAddressData(AddressDetails addressDetails)
        {
            try
            {
                return _client.SaveAddressData(addressDetails.StreetAddressLine1,
                    addressDetails.StreetAddressLine2, addressDetails.City, addressDetails.Province,
                    addressDetails.PostalCode, addressDetails.ClientId.ToString());
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }

        }

        public bool SaveClientData(ClientDetail clientDetails)
        {
            try
            {
                return _client.SaveClientData(clientDetails.Name, clientDetails.Surname, clientDetails.Gender,
                    clientDetails.IdNumber);
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }

        public bool SaveContactData(ContactDetails contactDetails)
        {
            try
            {
                return _client.SaveContactData(contactDetails.ClientId.ToString(),contactDetails.Type, contactDetails.Number);
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }
    }
}
