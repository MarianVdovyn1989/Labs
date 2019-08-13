using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    class ScreenOLED : ScreenColorful
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("here is logic for OLED screen can be added");
        }

        public override string GetComponentType()
        {
            return "OLED Screen";
        }
    }
}
