using System;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public abstract class ChargerBase
    {
        public string ChargingStandardName { get; }
        public double MaxChargingPower { get; }
        public ConnectionType connectionType { get; }

        public enum ConnectionType
        {
            Wireless,
            Wire
        }


    }
}