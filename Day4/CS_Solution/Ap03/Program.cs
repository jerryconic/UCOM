/*
List<IOpenClose> lst = [new Door(), new Door(), new Window()];
foreach (IOpenClose obj in lst)
    obj.Open();

foreach (IOpenClose obj in lst)
    obj.Close();
*/
IOpenClose d1 = new Door();
IOpenClose w1 = new Window();
d1.Open();
d1.Close();
w1.Open();
w1.Close();



public class Window : IOpenClose//Implement(實作)
{
    void IOpenClose.Close()
    {
        Console.WriteLine("Window is Closed.");
    }

    void IOpenClose.Open()
    {
        Console.WriteLine("Window is Open.");
    }
}

public class Door : IOpenClose
{
    void IOpenClose.Close()
    {
        Console.WriteLine("Door is Closed.");
    }

    void IOpenClose.Open()
    {
        Console.WriteLine("Door is Open.");
    }
}

public interface IOpenClose
{
    void Open();
    void Close();
}