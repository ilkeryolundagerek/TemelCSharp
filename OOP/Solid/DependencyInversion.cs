using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Solid
{
    internal class DependencyInversion
    {
    }

    //Bad way..
    public class SMSBad
    {
        public void SendSMS()
        {
        }
    }
    public class EMailBad
    {
        public void SendEMail()
        {
        }
    }
    public class WhistleBad
    {
        public void SendCall()
        {
        }
    }

    public class MessageCenterBad
    {
        private SMSBad sMSBad = new SMSBad();
        private EMailBad eMailBad = new EMailBad();
        private WhistleBad whistleBad = new WhistleBad();

        public void SendMessages()
        {
            sMSBad.SendSMS();
            eMailBad.SendEMail();
            whistleBad.SendCall();
        }
    }

    //Good way...

    public interface IMessageWay
    {
        void SendMessage();
    }

    public class SMSGood : IMessageWay
    {
        public void SendMessage()
        {
            SendSMS();
        }

        private void SendSMS() { Console.WriteLine("SMS"); }
    }

    public class EMailGood : IMessageWay
    {
        public void SendMessage()
        {
            SendEMail();
        }

        private void SendEMail() { Console.WriteLine("E-Mail"); }
    }

    public class WhistleGood : IMessageWay
    {
        public void SendMessage()
        {
            SendCall();
        }

        private void SendCall() { Console.WriteLine("Whistle"); }
    }

    public class MessageCenterGood
    {
        private List<IMessageWay> ways;

        public MessageCenterGood(List<IMessageWay> ways)
        {
            this.ways = ways;
        }
        public void SendAllMessage()
        {
            foreach (IMessageWay way in ways)
            {
                way.SendMessage();
            }
        }
    }
}
