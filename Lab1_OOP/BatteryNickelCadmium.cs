using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    class BatteryNickelCadmium : Battery
    {
        public BatteryNickelCadmium(int capacity, bool wirelessCharge, bool fastCharge) : base(capacity, wirelessCharge, fastCharge)
        {
        }

        public override string GetComponentType()
        {
            return "NickelCadmium";
        }
    }
}
