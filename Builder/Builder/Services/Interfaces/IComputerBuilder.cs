using Builder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Services.Interfaces;

interface IComputerBuilder
{
    public Computer ComputerToBuild { get; set; }
    public void setMotherBoard(string make, string model);
    void setMotherBoard();
    public void setProcessor(string make, int Hz);
    void setProcessor();
    public void setSSD(string make, int capacity);
    void setSSD();
}
