using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    class ScreenRetina : ScreenColorful
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("here is logic for Retina screen can be added");
        }

        public override string GetComponentType()
        {
            return "Retina Screen";
        }
    }
}
