using AbstractFactory.Entitites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entitites.Classes;

class OfficeChair : IChair
{
    public void Create()
    {
        Console.WriteLine("Office Chair Created");
    }
}
