
using NSB.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using NSB.Messages.Commands;

namespace WorkerRole1
{
    class CommandHandler : IHandleMessages<PlaceOrderCommand>
    {
        public void Handle(PlaceOrderCommand orderCommand)
        {
            Console.Write("order accepted");

        }
    }
}
