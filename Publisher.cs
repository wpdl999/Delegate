using System;

public class Publisher
{
	public Publisher()
	{

        public delegate void PublishMessageDel(string msg);

        //Declare an instance variable which is a Delegate object 
        public PublishMessageDel publishmsg = null;

        //Method used to Invoke Delegate
        public void PublishMessage(string message)
        {
            //Invoke Delegate
            publishmsg.Invoke(message);
        }
    }
}
