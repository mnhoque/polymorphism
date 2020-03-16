using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session105_Polymorphosm
{
    abstract class Laptop
    {
        abstract public void PowerOn();
        abstract public void Sleep();
        abstract public void Hibernate();
        abstract public void Fold();
        abstract public void Boot();
        //public virtual void Boot()//virtual: it may be overidable
        //{
        //    Console.WriteLine("booting......");
        //}
    }

    abstract class Tv
    {
        abstract public void Start();
        abstract public void TuneChannel(int channelId);
        abstract public void SetVolume(int level);
        abstract public void Stop();
    }

    class Lg : Tv
    {
        public override void SetVolume(int level)
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public override void TuneChannel(int channelId)
        {
            throw new NotImplementedException();
        }
    }

    class Dell : Laptop
    {
        public override void Fold()
        {
            Console.WriteLine("Dell Folding...");
        }

        public override void Hibernate()
        {
            Console.WriteLine("Dell hibernating...");
        }

        public override void PowerOn()
        {
            Console.WriteLine("Dell power on..."); 
        }

        public override void Sleep()
        {
            Console.WriteLine("Dell Sleep...");
        }

        public override void Boot()
        {
            Console.WriteLine("dell can boot");
        }

        public void Cool()
        {
            Console.WriteLine("cooling................dell");
        }
    }

    class Toshiba : Laptop
    {
        public override void Fold()
        {
            Console.WriteLine("Toshiba Folding...");
        }

        public override void Hibernate()
        {
            Console.WriteLine("Toshiba hibernating...");
        }

        public override void PowerOn()
        {
            Console.WriteLine("Toshiba power on...");
        }

        public override void Sleep()
        {
            Console.WriteLine("Toshiba Sleep...");
        }


        public override void Boot()
        {
            Console.WriteLine("Toshiba booting...............");
        }
        public void RotateDisplay()
        {

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Laptop x;
            //x.PowerOn();
            Console.WriteLine("What Laptop Do you want?");
            string LaptopName = Console.ReadLine();

            if (LaptopName == "Dell")
                x = new Dell();
            else
                x = new Toshiba();

            Demonstrate(x);
            

            Console.ReadKey();
        }

        private static void Demonstrate(Laptop x)
        {
            x.PowerOn();
            x.Boot();
            x.Hibernate();
            x.Fold();
            
            if(x is Dell)
            {               
                ((Dell)x).Cool();
            }

            if (x is Toshiba)
            {
                ((Toshiba)x).RotateDisplay();
            }

        }
    }



}
