using Builder.Entities;
using Builder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Services.Classes;

class Director
{
    private readonly IComputerBuilder builder;

    public Director(IComputerBuilder builder)
    {
        this.builder = builder;
    }

    public  Computer BuildOfficeComputer()
    {
        builder.setMotherBoard();
        builder.setProcessor();
        builder.setSSD();

        return builder.ComputerToBuild;
    }

    public Computer BuildGamingComputer()
    {
        builder.setMotherBoard();
        builder.setProcessor();
        builder.setSSD();

        return builder.ComputerToBuild;
    }

    public Computer BuildDesignerComputer()
    {
        builder.setMotherBoard();
        builder.setProcessor();
        builder.setSSD();

        return builder.ComputerToBuild;
    }
}
