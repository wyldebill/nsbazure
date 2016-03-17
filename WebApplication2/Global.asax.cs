using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication2
{
    public class MvcApplication : System.Web.HttpApplication
    {

        private static ISendOnlyBus bus;

        private ISendOnlyBus startableBus;

        public static ISendOnlyBus Bus
        {
            get { return bus; }
        }


        protected void Application_Start()
        {

            var config = new BusConfiguration();

            config.Conventions();
            //        .DefiningCommandsAs(t => t.Namespace != null && t.Namespace.StartsWith("VideoStore") && t.Namespace.EndsWith("Commands"))
            //        .DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("VideoStore") && t.Namespace.EndsWith("Events"))
                 // .DefiningMessagesAs(t => t.Namespace != null && t.Namespace.StartsWith("Message") && !t.Namespace.EndsWith("RequestResponse"));
            //        .DefiningEncryptedPropertiesAs(p => p.Name.StartsWith("Encrypted"));
            //config.TraceLogger();
            
            config.UseTransport<AzureStorageQueueTransport>();
            //config.UsePersistence<AzureStoragePersistence>();
            config.PurgeOnStartup(true);
            //config.RijndaelEncryptionService();
            config.EnableInstallers();

            //BusConfiguration busConfiguration = new BusConfiguration();
            startableBus = NServiceBus.Bus.CreateSendOnly(config);
           
            bus = startableBus;
            //startableBus = NServiceBus.Bus.CreateSendOnly(config);
            //bus = startableBus.Start()


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
