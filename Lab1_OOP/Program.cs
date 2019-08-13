using System;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorpMobile MyMobile = new SimCorpMobile();

            //LAB#1: battary and screen
            string description = MyMobile.GetDescription();
            MyMobile.ShowDescription(description);

            //LAB#2: 
            //ICharger interface for Charger component type
            int Index=MyMobile.ChargerFactory.SelectComponent();
            MyMobile.BatteryCharger = MyMobile.ChargerFactory.Create(Index);
            description = MyMobile.BatteryCharger.Show();
            MyMobile.ShowDescription(description);
            //ICharger interface for Charger component type
            Index = MyMobile.PlayBackFactory.SelectComponent();
            MyMobile.PlaybackComponent = MyMobile.PlayBackFactory.Create(Index);
            MyMobile.Play("dummyObject");
            Console.ReadLine();
        }


    }
}
