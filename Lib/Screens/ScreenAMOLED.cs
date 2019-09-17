using SimCorp.IMS.CSharpPrepCourse.Lab.MyMobile.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class ScreenAMOLED : ScreenColorful, IScreen
    {
        public ScreenAMOLED(int height, int width, int colorDepth, DisplayProductionTechnology ScreenTechnology) : base(height, width, colorDepth, ScreenTechnology)
        {
        }

        public override string ToString()
        {
            return "AMOLED Screen";
        }
    }
}
