public class Program
{
    static void Main(string[] args)
    {
        var streamReader = new StreamReader("heeej");
        try
        {

        }
        catch (Exception ex)
        {
            System.Console.WriteLine("an error occured, exception caught");
        }
        finally //will always be exc
        {
            System.Console.WriteLine("finally block excecuted");
            streamReader.Dispose();
        }

    }

}
