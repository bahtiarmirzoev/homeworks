using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace State.States;

public class DraftState : IState
{
    public void Publish(Document doc)
    {
        Console.WriteLine("Нельзя опубликовать из черновика.");
    }

    public void Send(Document doc)
    {
        Console.WriteLine("Документ отправлен на редактирование.");
        doc.State = new SentState();
    }

    public void PrintStatus()
    {
        Console.WriteLine("State draft");
    }
}


