using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystems;

public class PlaneSystem
{
    public void StartPlaneEngine()
    {
        Console.WriteLine("Start plane engine");
    }

    public void StopPlaneEngine()
    {
        Console.WriteLine("Stop plane engine");
    }
}
