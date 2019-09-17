using SimCorp.IMS.CSharpPrepCourse.Lab.MyMobile.ClassLibrary.CommandLineUserInterface;
using System;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            IOutput Console;

            Console = new ConsoleOutput();

            SimCorpMobile MyMobile = new SimCorpMobile(Console);

            //LAB#1: battary and screen
            Console.WriteLine(MyMobile.ToString());


            //LAB#2: 
            //======================================================================
            //Charger component type
            //======================================================================
            int Index;

            //Ask User for index
            Index =MyMobile.ChargerFactory.SelectComponentIndex();
            //Create Component Class based on index
            MyMobile.BatteryCharger = MyMobile.ChargerFactory.Create(Index);

            //======================================================================
            //PlayBack component type
            //======================================================================

            //Ask User for index
            Index = MyMobile.PlayBackFactory.SelectComponentIndex();
            //Create Component Class based on index
            MyMobile.PlaybackComponent = MyMobile.PlayBackFactory.Create(Index);
            MyMobile.Play();

            //======================================================================
            //Screen component type
            //======================================================================

            //Ask User for index
            Index = MyMobile.Screenfactory.SelectComponentIndex(); ;
            //Create Component Class based on index
            MyMobile.PlaybackComponent = MyMobile.PlayBackFactory.Create(Index);



            System.Console.ReadLine();
        }


    }
}
