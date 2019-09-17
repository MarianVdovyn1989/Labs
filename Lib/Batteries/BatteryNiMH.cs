using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    class BatteryNiMH : BatteryBase
    {
        public BatteryNiMH(int capacity) : base(capacity)
        {
        }

        public override string ToString()
        {
            return "NiMH";
        }
    }
}
