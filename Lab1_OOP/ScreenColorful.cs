using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class ScreenColorful : ScreenBase
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("here is logic for ColorfulScreen screen can be added");
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine($"This is Colorful Image with level of brightness {brightness}");
        }

        public override string GetComponentType()
        {
            return "Colorful Screen";
        }
    }
}
