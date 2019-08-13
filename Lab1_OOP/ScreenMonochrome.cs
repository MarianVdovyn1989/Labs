using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class ScreenMonochrome : ScreenBase
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine($"This is Monochrome Image");
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine($"This is Monochrome Image with level of brightness {brightness}");
        }

        public override string GetComponentType()
        {
            return "Monochrome Screen";
        }
    }
}
