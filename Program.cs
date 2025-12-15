public class Program
{
    static void Main(string[] args)
    {

        try
        {
            var api = new YoutubeApi();
            var videos = api.GetVideos("amalie");

        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

    }

}
