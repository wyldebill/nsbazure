using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSB.Messages.Commands
{
    public class PlaceOrderCommand
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
    }
}
