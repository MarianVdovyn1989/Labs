using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    class BatteryNiMH : Battery
    {
        public BatteryNiMH(int capacity, bool wirelessCharge, bool fastCharge) : base(capacity, wirelessCharge, fastCharge)
        {
        }

        public override string GetComponentType()
        {
            return "NiMH";
        }
    }
}
