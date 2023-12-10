using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace State.States;

public class PublishedState : IState
{
    public void Publish (Document doc)
    {
        Console.WriteLine ("Document already published")
    }

    public void Send(Document doc) 
    {
        Console.WriteLine ("You cannot send a document that has already been sent")
    }
    public void PrintStatus()
    {
        Console.WriteLine("State:Published");
    }
}
