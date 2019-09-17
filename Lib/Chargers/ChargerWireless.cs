using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class ChargerWireless : ChargerBase, ICharger
    {
        public void Charge(object data)
        {
            Console.WriteLine($"{nameof(ChargerWireless)} is enabled");
        }

        public string SetCharger()
        {
            string result = $"Set charger type: {nameof(ChargerWireless)} to Mobile";
            return result;
        }

        public override string ToString()
        {
            return $"{nameof(ChargerWireless)}";
        }
    }
}
