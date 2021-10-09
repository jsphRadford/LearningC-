using System;
using System.IO;

namespace ExceptionHandling
{


    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("most");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
