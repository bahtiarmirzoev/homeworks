using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace State;

public interface IState
{
    void Publish(Document doc);
    void Send(Document doc);

    void PrintStatus();
}
