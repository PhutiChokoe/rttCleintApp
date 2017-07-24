using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Services;
using Service.Interface;
using Service.Models;

namespace Service
{
    /// <summary>
    /// Summary description for DataService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataService : System.Web.Services.WebService
    {

        private IClientRepository IclientRepository { get; set; }
        private RttLogger _rttLogger = new RttLogger();

        [WebMethod]
        public List<ClientDetail> GetAllClients()
        {
            try
            {
                IclientRepository = new ClientRepository();
                var result = IclientRepository.GetAllClients();
                var clients = (from DataRow row in result.Rows
                               select new ClientDetail
                               {
                                   Id = row.Field<Guid>(0),
                                   Name = row.Field<string>(1),
                                   Gender = row.Field<string>(2),
                                   Surname = row.Field<string>(3),
                                   IdNumber = row.Field<long>(4)
                               }).ToList();

                return clients ?? null;
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
           
        }
        [WebMethod]
        public bool SaveClientData(string name, string surname, string gender, long idNumber)
        {
            try
            {
                IclientRepository = new ClientRepository();
                ClientDetail client = new ClientDetail
                {
                    Name = name,
                    Gender = gender,
                    Surname = surname,
                    IdNumber = idNumber,
                    Id = Guid.NewGuid()
                };
                var result = IclientRepository.SaveClientDetails(client);
                return result;
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }

        [WebMethod]
        public bool SaveAddressData(string streetAddressline1, string streetAddressline2, string city, string province, string postalCode, string clientId)
        {
            try
            {
                IclientRepository = new ClientRepository();
                AddressDetails client = new AddressDetails
                {
                    ClientId = Guid.Parse(clientId),
                    StreetAddressLine1 = streetAddressline1,
                    StreetAddressLine2 = streetAddressline2,
                    City = city,
                    Province = province,
                    PostalCode = postalCode
                };
                var result = IclientRepository.SaveClientAddressDetails(client);
                return result;
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }

        [WebMethod]
        public bool SaveContactData(string clientId, string Type, string number)
        {
            try
            {
                IclientRepository = new ClientRepository();
                ContactDetails client = new ContactDetails
                {
                    ClientId = Guid.Parse(clientId),
                    Number = number,
                    Type = Type
                };
                var result = IclientRepository.SaveClientContactDetails(client);
                return result;
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }
        [WebMethod]
        public List<AddressDetails> GetAddressDetails(string clientId)
        {
            try
            {
                IclientRepository = new ClientRepository();
               
                var result = IclientRepository.GetClientAddressDetails(clientId);
                var data = (from DataRow row in result.Rows
                               select new AddressDetails()
                               {
                                   StreetAddressLine1 = row.Field<string>(0),
                                   StreetAddressLine2 = row.Field<string>(1),
                                   City = row.Field<string>(2),
                                   Province = row.Field<string>(3),
                                   PostalCode = row.Field<string>(4)
                               }).ToList();

                return data ?? null;
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }
        [WebMethod]
        public List<ContactDetails> GetContactDetails(string clientId)
        {
            try
            {
                IclientRepository = new ClientRepository();
                var result = IclientRepository.GetClientContactDetails(clientId);
                var data = (from DataRow row in result.Rows
                            select new ContactDetails()
                            {
                                Type = row.Field<string>(0),
                                Number = row.Field<string>(1),
                              
                            }).ToList();

                return data ?? null;
            }
            catch (Exception ex)
            {
                _rttLogger.WriteToLog(LogType.Fatal, ex.Message);
                throw;
            }
        }




    }
}
