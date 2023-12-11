using FlyWeight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Classes;
class Furniture : IFurniture
{

    private string type;

    public Furniture(string type)
    {
        this.type = type;
    }

    public void Coordinates(int x , int y)
    {
        Console.WriteLine("Furniture located '{type}' on coordinates ({x}, {y})")
    }
}
