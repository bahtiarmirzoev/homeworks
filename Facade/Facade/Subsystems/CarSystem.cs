using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystems;

public class Carsystem
{
    public void StartCarEngine()
    {
        Console.WriteLine("Start car engine");
    }

    public void StopCarEngine()
    {
        Console.Write("Stop car engine");
    }
}
