using AbstractFactory.Entitites.Classes;
using AbstractFactory.Entitites.Interfaces;
using AbstractFactory.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories.Classes;

public class OfficeFurnitureFactory : IFurnutereFactory
{

    public ITable CreateTable()
    {
        return new OfficeTable();
    }
    public IChair CreateChair()
    {
        return new OfficeChair();
    }
    
}