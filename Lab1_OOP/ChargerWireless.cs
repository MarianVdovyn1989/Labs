using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class ChargerWireless : Charger
    {
        public void Charge(object data)
        {
            Console.WriteLine($"{nameof(ChargerWireless)} is enabled");
        }

        public override string Show()
        {
            string result = $"Set charger type: {nameof(ChargerWireless)} to Mobile";
            return result;
        }
    }
}
