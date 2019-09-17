using SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone;
using SimCorp.IMS.CSharpPrepCourse.Lab.MyMobile.ClassLibrary.CommandLineUserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MyMobile.ClassLibrary.Screens
{
    public class ScreenFactory : ConsoleOutput
    {
        public IScreen Create(int screenInputIndex)
        {
            switch (screenInputIndex)
            {
                case 1:
                    return new ScreenAMOLED(2560,1440,8,ScreenColorful.DisplayProductionTechnology.AMOLED);

                case 2:
                    return new ScreenIPS(1920,1080,10,ScreenColorful.DisplayProductionTechnology.IPS);
                case 3:
                    return new ScreenMonochrome(640,480,2);
                // can't avoid default line as this method must return something
                default:
                    return new ScreenIPS(1920, 1080, 10, ScreenColorful.DisplayProductionTechnology.IPS);
            }
        }

        //methods inherited from abstract class - unique implementation
        public override StringBuilder BuildComponentsSelector()
        {
            var OptionBuilder = new StringBuilder();
            OptionBuilder.AppendLine($"===========================================================");
            OptionBuilder.AppendLine($"1 - ScreenAMOLED");
            OptionBuilder.AppendLine($"2 - ScreenIPS");
            OptionBuilder.AppendLine($"3 - ScreenMonochrome");
            OptionBuilder.AppendLine($"===========================================================");
            return OptionBuilder;
        }

        //methods inherited from abstract class - unique implementation
        public override StringBuilder BuildHeaderSelector()
        {
            var HeaderBuilder = new StringBuilder();
            HeaderBuilder.AppendLine($"===========================================================");
            HeaderBuilder.AppendLine($"Select Screen Component from the list below (specify index)");
            HeaderBuilder.AppendLine($"===========================================================");
            return HeaderBuilder;
        }


    }
}
