using Factory.Entities.Classes;
using Factory.Entities.Interfaces;
using Factory.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory.Classes;




class TruckFactory : ITransportFactory
{
    public ITransport CreateTransport()
    {
        ITruck truck = new Truck()
        {
            Name = "Man",
            color = "Black",
            volume = 10998
        };

        return truck;
    }
}

