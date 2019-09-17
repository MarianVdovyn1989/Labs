using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public abstract class ScreenColorful : ScreenBase
    {
        public ScreenColorful(int height, int width, int colorDepth, DisplayProductionTechnology ScreenTechnology) :base(height, width, colorDepth)
        {
            this.ScreenTechnology = ScreenTechnology;
        }


        public DisplayProductionTechnology ScreenTechnology{get;}
        public enum DisplayProductionTechnology
        {
            AMOLED,
            IPS
        }
    }
}
