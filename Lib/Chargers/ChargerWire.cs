using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class ChargerWire : ChargerBase, ICharger
    {
        public void Charge(object data)
        {
            Console.WriteLine($"{nameof(ChargerWire)} is enabled");
        }

        public string SetCharger()
        {
            string result = $"Set charger type: {nameof(ChargerWire)} to Mobile";
            return result;
        }

        public override string ToString()
        {
            return $"{nameof(ChargerWire)}";
        }


    }
}
