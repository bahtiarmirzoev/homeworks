using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Entities.Interfaces;

interface ISedan:ITransport
{
    public string color { get; set; }
}
