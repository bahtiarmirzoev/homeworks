using Factory.Entities.Classes;
using Factory.Entities.Interfaces;
using Factory.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factory.Classes;

class SUVFactory : ITransportFactory
{
    public ITransport CreateTransport()
    {
        ISUV suv = new SUV()
        {
            Name = "Mercedes GLS Maybach",
            color = "Black",
            volume = 3992
        };
        return  suv;
    }
}




