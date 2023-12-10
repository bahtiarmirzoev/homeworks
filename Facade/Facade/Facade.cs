using Facade.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade;

public class TransportControlFacade
{
    private Carsystem _carSystem;
    private TrainSystem _trainSystem;
    private PlaneSystem _planeSystem;

    public TransportControlFacade()
    {
        _carSystem = new Carsystem();
        _trainSystem = new TrainSystem();
        _planeSystem = new PlaneSystem();
    }

    public void StartCar()
    {
        _carSystem.StartCarEngine();
    }

    public void StopCar()
    {
        _carSystem.StopCarEngine();
    }

    public void StartTrain()
    {
        _trainSystem.StartTrainEngine();
    }

    public void StopTrain()
    {
        _trainSystem.StopTrainEngine();
    }

    public void StartPlain()
    {
        _planeSystem.StartPlaneEngine();
    }

    public void StopPlane()
    {
        _planeSystem.StopPlaneEngine();
    }
}

