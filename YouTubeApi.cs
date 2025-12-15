
public class YouTubeApi
{
    public List<Video> GetVideos(string user)
    {
        try
        {
            // Access YouTube web service
            // Read the data
            // Create a list of Video objects
        }
        catch (Exception ex)
        {
            throw new YoutubeException("could not fetch the videos from youtube", ex);
        }

        return new List<Video>();
    }
}