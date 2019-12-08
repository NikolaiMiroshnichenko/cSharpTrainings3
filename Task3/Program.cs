using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Task3
{
    class NewsResourse
    {
        public event EventHandler makeMessage;
        public void sendMessage()
        {
            makeMessage?.Invoke(this, EventArgs.Empty);
        }
    }
    class Client
    {

        public void reactToMessage(Object obj, EventArgs e)
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
            nr.makeMessage += client1.reactToMessage;

            TimerCallback timerCB = new TimerCallback(staticMethodToCallEvent);
            Timer timer = new Timer(staticMethodToCallEvent, nr, 0, period);

            Console.ReadKey();
        }

        static void staticMethodToCallEvent(Object state)
        {
            NewsResourse nr = (NewsResourse)state;
            nr.sendMessage();
        }
    }
}

