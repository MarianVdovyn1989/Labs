using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class ChargerRegular : Charger
    {
        public void Charge(object data)
        {
            Console.WriteLine($"{nameof(ChargerRegular)} is enabled");
        }

        public override string Show()
        {
            string result = $"Set charger type: {nameof(ChargerRegular)} to Mobile";
            return result;
        }
    }
}
