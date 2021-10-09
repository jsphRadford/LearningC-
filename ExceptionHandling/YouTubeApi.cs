using System;
using System.Collections.Generic;

namespace ExceptionHandling
{

    public class YouTubeExpection : Exception
    {
        public YouTubeExpection(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }


    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access YouTube web service
                //read data
                //create a list of video objects
                throw new Exception("Oops some low level youtube error");
            }
            catch(Exception ex)
            {
                //Log
                throw new YouTubeExpection("Could not fetch the videos from Youtube ", ex);
            }

            return new List<Video>();
        }
    }
}
