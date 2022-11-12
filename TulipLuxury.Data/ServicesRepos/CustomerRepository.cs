using System;
using System.Collections.Generic;
using TulipLuxury.Helpers.Contracts;
using TulipLuxury.Data.ContractsRepo;

namespace TulipLuxury.Data.ServicesRepos
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IReadWriteToJson _readWriteToJson;

        public CustomerRepository(IReadWriteToJson readWriteToJson)
        {
            _readWriteToJson = readWriteToJson;
        }


        /// <summary>
        /// Getting the Customer from the customer file, using it's Id
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public string CollectCustomerDetails(string CustomerId)
        {
            //string path = Files.CustomerPath;
            //List<string> CustomerInfo = new List<string>();

            //CustomerInfo = _readWriteToJson.ReadFile(path);
            string customer = string.Empty;

            //foreach (var item in CustomerInfo)
            //{
            //    if (item.Split(",")[0] == CustomerId)
            //    {
            //        return customer = item;
            //    }
            //}
            return customer;
        }


        public string getCustomerByEmail(string email)
        {
            //string path = Files.CustomerPath;
            //List<string> custinfo = new List<string>();
            //custinfo = _readWriteToJson.ReadFile(path);

            string custmer = string.Empty;
            //foreach (var line in custinfo)
            //{
            //    if (line.Split(",")[4] == email)
            //    {
            //        return custmer = line;
            //    }
            //}
            return custmer;
        }
    }
}

