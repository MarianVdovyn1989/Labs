using System;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public abstract class Mobile
    {
        public IPlayBack PlaybackComponent { get; set; }

        public void Play()
        {
            PlaybackComponent.Play();
        }
        public IOutput Output { get; set; }
        public ICharger BatteryCharger { get; set; }



        public abstract ScreenBase Screen {get;}
        public abstract BatteryBase Battery { get; }
        public abstract TouchBasic Touch { get; }


        public override string ToString()
        {
            var DescriptionBuilder = new StringBuilder();
            DescriptionBuilder.AppendLine($"{nameof(Screen)} Type: {Screen.ToString()}");
            DescriptionBuilder.AppendLine($"{nameof(Battery)} Type: {Battery.ToString()}");
            DescriptionBuilder.AppendLine($"{nameof(Touch)} Type: {Touch.ToString()}");
            return DescriptionBuilder.ToString();
        }
    }


}