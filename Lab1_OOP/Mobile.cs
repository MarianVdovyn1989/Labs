using System;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public abstract class Mobile
    {
        public IPlayBack PlaybackComponent { get; set; }

        public void Play(object data)
        {
            PlaybackComponent.Play(data);
        }

        public ICharger BatteryCharger { get; set; }

        public ISelectComponent SoundPlayBack { get; set; }



        public abstract ScreenBase Screen {get;}
        public abstract Battery Battery { get; }
        public abstract TouchBasic Touch { get; }

        private void Show(IScreenImage screenImage)
        {
            Screen.Show(screenImage, 75);         
        }
        

        public string GetDescription()
        {
            var DescriptionBuilder = new StringBuilder();
            DescriptionBuilder.AppendLine($"{nameof(Screen)} Type: {Screen.GetComponentType()}");
            DescriptionBuilder.AppendLine($"{nameof(Battery)} Type: {Battery.GetComponentType()}");
            DescriptionBuilder.AppendLine($"{nameof(Touch)} Type: {Touch.GetComponentType()}");
            return DescriptionBuilder.ToString();
        }
    }


}