using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    class BatteryLithiumPolymer : BatteryBase
    {
        public BatteryLithiumPolymer(int capacity):base(capacity)
        {
        }

        public override string ToString()
        {
            return "LithiumPolymer";
        }
    }
}
