using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Task3
{
    class NewsResourse
    {
        
        public event ElapsedEventHandler makeMessage;

        public void sendMessge()
        {
            makeMessage?.Invoke(this, ElapsedEventArgs e);
        }
    }
    class Client
    {
        /*  private NewsResourse _nr;
          public Client(NewsResourse nr)
          {
              _nr = nr;
              _nr.makeMessage += reactToMessage;
          }*/
        public void reactToMessage()
        {
            Console.WriteLine("event happened");
        }
    }
    class Program
    {


        static void Main(string[] args)
        {


            NewsResourse nr = new NewsResourse();
            Client client1 = new Client();
            Client client2 = new Client();
            nr.makeMessage += client1.reactToMessage;

            var timer = new System.Timers.Timer(1000); // fire every 1 second
            timer.Elapsed += ATimer_Elapsed(nr);
            nr.sendMessge();

            Console.ReadKey();
        }
    }
}

           