using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class ChargerFast : Charger
    {
        public void Charge(object data)
        {
            Console.WriteLine($"{nameof(ChargerFast)} is enabled");
        }

        public override string Show()
        {
            string result = $"Set charger type: {nameof(ChargerFast)} to Mobile";
            return result;
        }
    }
}
