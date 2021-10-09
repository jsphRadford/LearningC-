using System;
using System.Threading;

namespace EventsAndDelegates
{

    public class VideoEventArgs
    {
        public Video Video { get; set; }

    }



    public class VideoEncoder
    {

        //Need 3 things to notifiy the subscripers to this event
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event, Publish the event

        //public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);

        //Delegate types
        //EventHandler
        //EventHandler<TEventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;
        
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}
