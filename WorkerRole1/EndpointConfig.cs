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
            builder.Conventions()
                .DefiningCommandsAs(t => t.Namespace != null && t.Namespace.StartsWith("NSB") && t.Namespace.EndsWith("Commands"));
                //.DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("VideoStore") && t.Namespace.EndsWith("Events"))
                //.DefiningMessagesAs(t => t.Namespace != null && t.Namespace.StartsWith("VideoStore") && t.Namespace.EndsWith("RequestResponse"));
                //.DefiningEncryptedPropertiesAs(p => p.Name.StartsWith("Encrypted"));

            builder.UseTransport<AzureStorageQueueTransport>();
            builder.UsePersistence<AzureStoragePersistence>();

            Console.WriteLine("endpoint is up");

        }
    }
}
