public class Program
{
    static void Main(string[] args)
    {
        StreamReader streamReader = null;
        try
        {
            var streamReader = new StreamReader("heeej");
            var content = streamReader.ReadToEnd();
            
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
