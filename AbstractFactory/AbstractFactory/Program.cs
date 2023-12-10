using AbstractFactory.Entitites.Interfaces;
using AbstractFactory.Factories.Classes;
using AbstractFactory.Factories.Interfaces;
static void Main()
{
    Console.WriteLine("Choose type 1- Office 2- Home");
    string choice = Console.ReadLine();

    IFurnutereFactory furnitureFactory = null;

    if (choice == "1")
    {
        furnitureFactory = new OfficeFurnitureFactory();
    }
    else if (choice == "2")
    {
        furnitureFactory = new HomeFurnitureFactory();
    }
    else
    {
        Console.WriteLine("Wrong selection . Stop Work");
        return;
    }

    ITable table = furnitureFactory.CreateTable();
    IChair chair = furnitureFactory.CreateChair();

    table.Create();
    chair.Create();
}
