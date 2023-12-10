using AbstractFactory.Entitites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories.Interfaces;

public interface IFurnutereFactory
{
    ITable CreateTable();
    IChair CreateChair();
}