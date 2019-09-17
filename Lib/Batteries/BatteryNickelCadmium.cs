using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class BatteryNickelCadmium : BatteryBase
    {
        public BatteryNickelCadmium(int capacity) : base(capacity)
        {
        }

        public override string ToString()
        {
            return "NickelCadmium";
        }
    }
}
