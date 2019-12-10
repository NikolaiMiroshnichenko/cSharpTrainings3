using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Phone
    {
        public int number { get; set; }
        public int calledNumber { get; set; }
        public string message { get; set; }
        public Phone(int number)
        {
            this.number = number;
        }
        public delegate void someDelegate(Phone phone1);
        public event someDelegate call;
        public void makeCall()
        {
            if (calledNumber != 0)
            {
                call?.Invoke(this);
            }
            else
            {
                Console.WriteLine("You cant make phone call cause you didnt input number");
            }
        }
    }
    class PhoneStation
    {
        public List<Phone> phonesList = new List<Phone>();
        public Phone createPhone(int num)
        {
            Phone phone = new Phone(num);
            phonesList.Add(phone);
            return phone;
        }
        public void ServiceCall(Phone phoneCaller)
        {
            int i = 0;
            Phone calledPhone;
            foreach (Phone ph in phonesList)
            {
                if (phoneCaller.calledNumber == ph.number)
                {
                    calledPhone = ph;
                    calledPhone.message = "Input call";
                    Console.WriteLine(calledPhone.message);
                    i = 1;
                }
            }
            if (i == 0)
            {
                phoneCaller.message = "Called number is not exist";
                Console.WriteLine(phoneCaller.message);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PhoneStation ps = new PhoneStation();
            Phone phone1 = ps.createPhone(232323);
            Phone phone2 = ps.createPhone(124562);
            Phone phone3 = ps.createPhone(676745);
            Phone phone4 = ps.createPhone(956239);

            phone1.call += ps.ServiceCall;
            phone2.call += ps.ServiceCall;
            phone3.call += ps.ServiceCall;

            phone1.calledNumber = 3484;
            phone2.calledNumber = 676745;

            phone1.makeCall();
            phone2.makeCall();
            phone3.makeCall();

            Console.ReadKey();
        }
    }
}

