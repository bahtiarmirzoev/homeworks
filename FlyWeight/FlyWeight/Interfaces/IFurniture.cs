using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Interfaces;

public interface IFurniture
{
    void Coordinates(int x, int y);
    void Place(int x, int y);
}

