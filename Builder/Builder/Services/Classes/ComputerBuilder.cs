using Builder.Entities;
using Builder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Services.Classes;

class ComputerBuilder : IComputerBuilder
{
    
    public Computer ComputerToBuild { get; set; }

    public ComputerBuilder()
    {
        ComputerToBuild = new Computer();
    }
    public void setMotherBoard(string make, string model)
    {
        throw new NotImplementedException();
    }

    public void setProcessor(string make, int Hz)
    {
        throw new NotImplementedException();
    }

    public void setSSD(string make, int capacity)
    {
        throw new NotImplementedException();
    }

    public void setMotherBoard()
    {
        throw new NotImplementedException();
    }

    public void setProcessor()
    {
        throw new NotImplementedException();
    }

    public void setSSD()
    {
        throw new NotImplementedException();
    }
}
