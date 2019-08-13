using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class ChargerFactory : SelectComponent, ISelectComponent
    {
        public ICharger Create(int batteryType)
        {
            switch (batteryType)
            {
                case 1:
                    return new ChargerFast();

                case 2:
                    return new ChargerWireless();
                case 3:
                    return new ChargerRegular();
                // can't avoid default line as this method must return something
                default:
                    return new ChargerRegular();
            }
        }


        //method implemented from ISelectComponent
        public int SelectComponent()
        {
            while (true)
            {
                Console.WriteLine(GetHeader());
                
                var OptionBuilder = GetComponents();
                Console.Write(OptionBuilder);

                var line = Console.ReadLine();
                Exception Ex = null;
                int Index = 0;
                try
                {
                    //convert to integer
                    var index = int.Parse(line);
                    //check that int value is within the specified range of current 'show components' method
                    //method inherited from abstract class - not unique
                    Index = ValidateIndex(index, OptionBuilder);
                    return Index;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Ex = ex;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Ex = ex;
                }
                finally
                {
                    //method inherited from abstract class - not unique
                    Console.WriteLine(ReturnSelectedOption(OptionBuilder, Ex, Index));
                }
            }
        }

        //methods inherited from abstract class - unique implementation
        public override StringBuilder GetHeader()
        {
            var HeaderBuilder = new StringBuilder();
            HeaderBuilder.AppendLine($"===========================================================");
            HeaderBuilder.AppendLine($"Select Charge Component from the list below (specify index)");
            HeaderBuilder.AppendLine($"===========================================================");
            return HeaderBuilder;
        }

        public override StringBuilder GetComponents()
        {
            var OptionBuilder = new StringBuilder();
            OptionBuilder.AppendLine($"===========================================================");
            OptionBuilder.AppendLine($"1 - ChargerFast");
            OptionBuilder.AppendLine($"2 - ChargerWireless");
            OptionBuilder.AppendLine($"3 - ChargerRegular");
            OptionBuilder.AppendLine($"===========================================================");
            return OptionBuilder;
        }
    }
}
