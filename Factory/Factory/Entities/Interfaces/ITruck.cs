using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Entities.Interfaces;

interface ITruck : ITransport
{
    public string Name { get; set; }
    public int volume { get; set; }
}
