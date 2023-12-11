using FlyWeight.Classes;
using FlyWeight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight.Factory;

class FurnitureFactory
{
    private Dictionary<string, IFurniture> furnitureInstances = new Dictionary<string, IFurniture>();

    public IFurniture GetFurniture(string type)
    {
        if (!furnitureInstances.ContainsKey(type))
        {
            furnitureInstances[type] = new Furniture(type); // suda jelatelno osobo ne vnikat , chat gpt nachudil mne cto to 
        }

        return furnitureInstances[type];
    }
}