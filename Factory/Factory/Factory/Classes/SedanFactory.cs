using Factory.Entities.Classes;
using Factory.Entities.Interfaces;
using Factory.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory.Classes;

class SedanFactory:ITransportFactory
{
    public ITransport CreateTransport()
    {
        ISedan sedan = new Sedan()
        {
            Name = "Mercedes",
            color = "Black",
            volume = 6298
        };

        return sedan;
    }
}
