using System;

public class SendViaEmail
{
	public SendViaEmail()
	{

            public String EmailAddr { get; set; }

            public SendViaEmail() { }

            public SendViaEmail(String emailAddr)
            {
                EmailAddr = emailAddr;
            }

            public void sendEmail(string msg)
            {
                Console.WriteLine("The message" + "\"" + msg + "\" has already sent to " + EmailAddr);
            }

            public void Subscribe(Publisher pub)
            {
                pub.publishmsg += sendEmail;
            }

            public void UnSubscribe(Publisher pub)
            {
                pub.publishmsg -= sendEmail;
            }
      }
}
