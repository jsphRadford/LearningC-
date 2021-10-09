using System;

namespace EventsAndDelegates
{

    public class MailService
    {
        //Responsible for sending an email once video has been encoded
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Email sent..." + e.Video.Title);
        }
    }
}
