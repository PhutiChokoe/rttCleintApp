using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Service.Interface;

using NLog;

namespace Service.Models
{
    public class ClientRepository : IClientRepository
    {
        private RttLogger _rttLogger = new RttLogger();
        private IRepository _repository { get; set; }
        public DataTable GetAllClients()
        {
            _repository = new Repository();
            try
            {
                var query = "select * from ClientDetails";
                var result= _repository.CreateDataTable(query);
                return result;
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }

        public bool SaveClientDetails(ClientDetail clientDetails)
        {
            try
            {
                _repository = new Repository();
                var values = new Dictionary<string, string>() {
                          {"Name", clientDetails.Name},
                          {"Gender", clientDetails.Gender},
                          {"Surname", clientDetails.Surname},
                          {"IdNumber", clientDetails.IdNumber.ToString()},
                          {"Id",clientDetails.Id.ToString() }
                        };
                     _repository.SqlInsert("ClientDetails", values);
                return true;


            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                return false;
                throw;
            }
        }

        public bool SaveClientContactDetails(ContactDetails contactDetails)
        {
            try
            {
                _repository = new Repository();
                var values = new Dictionary<string, string>() {
                          {"Type", contactDetails.Type},
                          {"Number", contactDetails.Number.ToString()},
                          {"ClientId", contactDetails.ClientId.ToString()}
                        };
                _repository.SqlInsert("ContactDetails", values);
                return true;


            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                return false;
                throw;
            }
        }

        public bool SaveClientAddressDetails(AddressDetails addressDetails)
        {
            try
            {
                _repository = new Repository();
                var values = new Dictionary<string, string>() {
                          {"StreetAddressLine1", addressDetails.StreetAddressLine1},
                          {"StreetAddressLine2", addressDetails.StreetAddressLine2},
                          {"City", addressDetails.City},
                          {"Province", addressDetails.Province},
                          {"PostalCode",addressDetails.PostalCode },
                          {"ClientId",addressDetails.ClientId.ToString() }
                        };
                _repository.SqlInsert("AddressDetails", values);
                return true;


            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                return false;
                throw;
            }
        }

        public DataTable GetClientAddressDetails(string clientId)
        {
            _repository = new Repository();
            try
            {
                var query = "SELECT * FROM dbo.AddressDetails WHERE ClientId = '" + clientId +"'";
                var result = _repository.CreateDataTable(query);
                return result;
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }

        public DataTable GetClientContactDetails(string clientId)
        {
            _repository = new Repository();
            try
            {
                var query = "SELECT * FROM dbo.ContactDetails WHERE ClientId = '" + clientId + "'";
                var result = _repository.CreateDataTable(query);
                return result;
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }
    }
}