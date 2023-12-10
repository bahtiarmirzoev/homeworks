using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsystems;

public class TrainSystem
{
    public void StartTrainEngine() 
    {
        Console.WriteLine("Start train engine");
    }
    public void StopTrainEngine() 
    {
        Console.WriteLine("Stop train engine");
    }

}
