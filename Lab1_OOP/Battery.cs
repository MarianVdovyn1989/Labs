using System;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public abstract class Battery
    {
        public Battery(int capacity, bool wirelessCharge, bool fastCharge)
        {
            Capacity = capacity;
            WirelessCharge = wirelessCharge;
            FastCharge = fastCharge;
        }
        public abstract string GetComponentType();

        public int Capacity { get; set; }
        public bool WirelessCharge { get; set; }
        public bool FastCharge { get; set; }
        string WirelessChargeText
        {
            get
            {
                switch (WirelessCharge)
                {
                    case bool y when y == true:
                        return "Yes";
                    default:
                        return "No";
                }

            }
            
        }
        string FastChargeText
        {
            get
            {
                switch (FastCharge)
                {
                    case bool y when y == true:
                        return "Yes";
                    default:
                        return "No";
                }
            }

        }
    }
}