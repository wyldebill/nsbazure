
using NSB.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace WorkerRole1
{
    class CommandHandler : IHandleMessages<NSB.Messages.Order>
    {
        public void Handle(NSB.Messages.Order orderCommand)
        {
            Console.Write("order accepted");

        }
    }
}
