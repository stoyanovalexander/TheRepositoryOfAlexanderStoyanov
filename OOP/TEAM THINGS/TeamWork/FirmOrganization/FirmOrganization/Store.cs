using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmOrganization
{
    public class Store
    {
        public string StoreFor { get; set; }
        public Worker KeyOwner { get; set; }
        public int NumberOfTheStore { get; set; }

        public Store(string storeFor, Worker keyOwner, int numberOfTheStore)
        {
            this.StoreFor = storeFor;
            this.KeyOwner = keyOwner;
            this.NumberOfTheStore = NumberOfTheStore;
        }
    }
}
