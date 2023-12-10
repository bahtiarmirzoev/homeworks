using AbstractFactory.Entitites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entitites.Classes;

class OfficeTable : ITable
{
    public void Create()
    {
        Console.WriteLine("Offica Table created");
    }
}
