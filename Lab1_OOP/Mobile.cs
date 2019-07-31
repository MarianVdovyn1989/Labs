using System;
using System.Text;

namespace Lab1_OOP
{
    public abstract class Mobile
    {
        public IPlayBack PlaybackComponent { get; set; }

        public void Play(object data)
        {
            PlaybackComponent.Play(data);
        }

        public ICharger BatteryCharge { get; set; }

        public void Charge(object data)
        {
            BatteryCharge.Charge(data);
        }
        public int GetIndex(int index)
        {
            var result = BatteryCharge.GetIndex(index);
            return result;
        }

        public abstract ScreenBase Screen {get;}
        public abstract Battery Battery { get; }

        private void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage);         
        }
        

        public string GetDescription()
        {
            var DescriptionBuilder = new StringBuilder();
            DescriptionBuilder.AppendLine($"{nameof(Screen)} Type: {Screen.GetComponentType()}");
            DescriptionBuilder.AppendLine($"{nameof(Battery)} Type: {Battery.GetComponentType()}");
            return DescriptionBuilder.ToString();
        }
    }

    public class SimCorpMobile : Mobile
    {
        private readonly OLEDScreen vOLEDScreen = new OLEDScreen();
        private readonly Battery vNickelCadmium = new NickelCadmium(4200, true, false);
        public override ScreenBase Screen { get { return vOLEDScreen; } }
        public override Battery Battery { get { return vNickelCadmium; } }
    }
}