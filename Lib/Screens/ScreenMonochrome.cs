using SimCorp.IMS.CSharpPrepCourse.Lab.MyMobile.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class ScreenMonochrome : ScreenBase, IScreen
    {
        public ScreenMonochrome(int height, int width, int colorDepth) : base(height,width,colorDepth)
        {
        }


        public override string ToString()
        {
            return "Monochrome Screen";
        }
    }
}
