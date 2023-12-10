using State;

class Program
{
    static void Main()
    {
        Document document = new Document();

        document.PrintStatus();

        document.Send();
        document.PrintStatus();

        document.Publish();
        document.PrintStatus();

        document.Send();

       
    }
}

//spasibo indusam i AI