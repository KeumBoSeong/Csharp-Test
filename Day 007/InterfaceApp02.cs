// See https://aka.ms/new-console-template for more information

interface IWing
{
    
}
class Horse
{

}
class Unicon : Horse, IWing
{
    public void Fly()
    {
        Console.WriteLine("유니콘이 날다.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Unicon unicon = new Unicon();
        unicon.Fly();
    }
}
