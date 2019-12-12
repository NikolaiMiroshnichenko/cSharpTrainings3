using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Task3
{
    public class NewsResourse
    {
        public event EventHandler MakeMessage;
        public void SendMessage()
        {
            MakeMessage?.Invoke(this, EventArgs.Empty);
        }
    }
    public class Client
    {
        public void ReactToMessage(Object obj, EventArgs e)
        {
            Console.WriteLine("event happened");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter event period in ms");
            int.TryParse(Console.ReadLine(), out int period);
            NewsResourse nr = new NewsResourse();
            Client client1 = new Client();
            Client client2 = new Client();
            nr.MakeMessage += client1.ReactToMessage;

            TimerCallback timerCB = new TimerCallback(StaticMethodToCallEvent);
            Timer timer = new Timer(StaticMethodToCallEvent, nr, 0, period);

            Console.ReadKey();
        }
        static void StaticMethodToCallEvent(Object state)
        {
            NewsResourse nr = (NewsResourse)state;
            nr.SendMessage();
        }
    }
}

