namespace EventsAndDelegates
{
    partial class Program
    {


        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var encoder = new VideoEncoder(); //publisher
            var mailServce = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            encoder.VideoEncoded += mailServce.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;

            encoder.Encode(video);


        }
    }
}
