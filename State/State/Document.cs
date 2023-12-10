using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State;

public class Document
{
    public IState State { get; set; }

    public Document()
    {
      State = new DraftState();
    }

    public void Publish()
    {
        State.Publish(this);
    }
    public void Send()
    {
        State.Send(this);
    }
    public void PrintStatus()
    {
        State.PrintStatus();
    }
}
