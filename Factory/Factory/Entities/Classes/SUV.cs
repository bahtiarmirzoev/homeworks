using Factory.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Entities.Classes;




class SUV : ISUV
{
    public int volume { get; set; }
    public string color { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }
}


