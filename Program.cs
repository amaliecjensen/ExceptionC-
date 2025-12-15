public class Program
{
    static void Main(string[] args)
    {

        try
        {
            using (var streamReader = new StreamReader("hej"))
            {
                var content = streamReader.ReadToEnd();
            }

        }
        catch (Exception ex)
        {
            System.Console.WriteLine("an error occured, exception caught");
        }

    }

}
