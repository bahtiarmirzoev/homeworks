using FlyWeight.Factory;
using FlyWeight.Interfaces;

static void Main()
{
    FurnitureFactory factory = new FurnitureFactory();
    Random random = new Random();

    for (int i = 0; i < 10; i++)
    {
        int x = random.Next(1, 100);
        int y = random.Next(1, 100);
        string type = (i % 2 == 0) ? "chair" : "table"; // chto bi 1 iz 2 

        IFurniture furniture = factory.GetFurniture(type);
        furniture.Place(x, y);
    }
}