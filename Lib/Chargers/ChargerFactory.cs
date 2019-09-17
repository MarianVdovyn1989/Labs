using SimCorp.IMS.CSharpPrepCourse.Lab.MyMobile.ClassLibrary.CommandLineUserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class ChargerFactory : ConsoleOutput
    {
        public ICharger Create(int batteryType)
        {
            switch (batteryType)
            {
                case 1:
                    return new ChargerWire();
                case 2:
                    return new ChargerWireless();
                // can't avoid default line as this method must return something
                default:
                    return new ChargerWire();
            }
        }

        public override StringBuilder BuildHeaderSelector()
        {
            var HeaderBuilder = new StringBuilder();
            HeaderBuilder.AppendLine($"===========================================================");
            HeaderBuilder.AppendLine($"Select Charge Component from the list below (specify index)");
            HeaderBuilder.AppendLine($"===========================================================");
            return HeaderBuilder;
        }

        public override StringBuilder BuildComponentsSelector()
        {
            var OptionBuilder = new StringBuilder();
            OptionBuilder.AppendLine($"===========================================================");
            OptionBuilder.AppendLine($"1 - ChargerWire");
            OptionBuilder.AppendLine($"2 - ChargerWireless");
            OptionBuilder.AppendLine($"===========================================================");
            return OptionBuilder;
        }
    }
}
