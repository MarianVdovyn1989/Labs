using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class SimCorpMobile : Mobile
    {
        //explicit constructor
        public SimCorpMobile()
        {
            ChargerFactory = new ChargerFactory();
            PlayBackFactory = new PlayBackFactory();
        }

        private readonly ScreenBase vOLEDScreen = new ScreenOLED();
        private readonly Battery vNickelCadmium = new BatteryNickelCadmium(4200, true, false);
        private readonly TouchBasic vSingleTouch = new TouchSingle();

        public override ScreenBase Screen { get { return vOLEDScreen; } }
        public override Battery Battery { get { return vNickelCadmium; } }
        public override TouchBasic Touch { get { return vSingleTouch; } }

        public ChargerFactory ChargerFactory { get; }
        public PlayBackFactory PlayBackFactory { get; }


        public void ShowDescription(string description)
        {
            Console.WriteLine(description);
            Console.ReadLine();
        }
    }
}
