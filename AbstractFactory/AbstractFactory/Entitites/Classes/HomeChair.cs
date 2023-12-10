using AbstractFactory.Entitites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entitites.Classes;

class HomeChair:IChair
{
    public void Create()
    {
        Console.WriteLine("Home Chair Created");
    }
}

