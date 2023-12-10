using Facade;

class Program
{
    static void Main()
    {
        TransportControlFacade transportFacade = new TransportControlFacade();
        transportFacade.StartCar();
        transportFacade.StopCar();

        transportFacade.StartTrain();
        transportFacade.StopTrain();
        
        transportFacade.StartPlain();
        transportFacade.StopPlane();
    }
}