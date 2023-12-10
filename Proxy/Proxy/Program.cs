using System;

public interface IRealServer
{
    void Request();
}

public class RealServer : IRealServer
{
    public void Request()
    {
        Console.WriteLine("Realniy server: Obrabotka zaprosa");
    }
}
public class ServerProxy : IRealServer
{
    private RealServer _realServer;

    public void Request()
    {
        if (_realServer == null)
        {
            Console.WriteLine("ServerProxy: Creating RealServer instance...");
            _realServer = new RealServer();
        }
        Console.WriteLine("ServerProxy: Authenticating the request...");

        _realServer.Request();
    }
}

class program
{
    static void main()
    {
        IRealServer server = new ServerProxy();
        server.Request();
    }
}

//Thank s to ErcodY , ChatGPT , Github copilot , and me