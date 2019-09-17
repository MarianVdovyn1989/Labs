using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    class BatteryLithiumIon : BatteryBase
    {
        public BatteryLithiumIon(int capacity):base( capacity)
        {
        }

        public override string ToString()
        {
            return "LithiumIon";
        }
    }
}
