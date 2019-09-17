using SimCorp.IMS.CSharpPrepCourse.Lab.MyMobile.ClassLibrary.Screens;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class SimCorpMobile : Mobile
    {
        //explicit constructor
        public SimCorpMobile(IOutput Output)
        {
            ChargerFactory = new ChargerFactory();
            PlayBackFactory = new PlayBackFactory(Output);
            Screenfactory = new ScreenFactory();
            vOLEDScreen = new ScreenAMOLED(800, 600, 8, ScreenColorful.DisplayProductionTechnology.AMOLED);
            vNickelCadmium = new BatteryNickelCadmium(4200);
            vSingleTouch = new TouchSingle();
        }

        private readonly ScreenBase vOLEDScreen;
        public override ScreenBase Screen { get { return vOLEDScreen; } }

        private readonly BatteryBase vNickelCadmium;
        public override BatteryBase Battery { get { return vNickelCadmium; } }

        private readonly TouchBasic vSingleTouch;
        public override TouchBasic Touch { get { return vSingleTouch; } }

        public ChargerFactory ChargerFactory { get; }
        public PlayBackFactory PlayBackFactory { get; }
        public ScreenFactory Screenfactory { get; }
    }
}
