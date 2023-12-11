using Builder.Parts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Parts.Classes;

class SSD : IPart
{
    public string Make { get; set; }

    public int Capacity { get; set; }
}
