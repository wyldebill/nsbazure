using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerRole1
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Worker
    {
        public void Customize(BusConfiguration builder)
        {
            builder.UseTransport<AzureStorageQueueTransport>();
            builder.UsePersistence<AzureStoragePersistence>();

            Console.WriteLine("endpoint is up");

        }
    }
}
