using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class PlayBackFactory: ISelectComponent
    {
        public IPlayBack Create(int soundOutputDevice)
        {
            //var c1 = consoleoutpu();
            switch (soundOutputDevice)
            {
                case 1:
                    return new PlayBackIPhoneHeadset();

                case 2:
                    return new PlayBackPhoneSpeaker();
                case 3:
                    return new PlayBackSamsungHeadset();
                case 4:
                    return new PlayBackUnofficialHeadset();
                // can't avoid default line as this method must return something
                default:
                    return new PlayBackUnofficialHeadset();
            }
        }

        public int SelectComponent()
        {
            while (true)
            {
                Console.WriteLine($"=============================================================");
                Console.WriteLine($"Select PlayBack Component from the list below (specify index)");
                Console.WriteLine($"=============================================================");

                var OptionBuilder = GetComponents();
                //showcomponents
                Console.Write(OptionBuilder);

                var line = Console.ReadLine();
                Exception Ex = null;
                int Index = 0;
                try
                {
                    //convert to integer
                    var index = int.Parse(line);
                    //check that int value is within the specified range of current 'show components' method
                    index = GetIndex(index);
                    Index = index;
                    return index;
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
                    Console.WriteLine("***");
                    ShowSelectedOption(OptionBuilder, Ex, Index);
                }
            }
        }

        private static void ShowSelectedOption(StringBuilder OptionBuilder, Exception Ex, int Index)
        {
            if (Ex == null && OptionBuilder.Length > 0)
            {
                string[] Options = OptionBuilder.ToString().Replace("\r", "").Split("\n");
                string SelectedLine = Options[Index] + $" option was selected";
                Console.WriteLine(SelectedLine);
            }
        }


        public StringBuilder GetComponents()
        {
            var DescriptionBuilder = new StringBuilder();
            DescriptionBuilder.AppendLine($"===========================================================");
            DescriptionBuilder.AppendLine($"1 - PlayBackIPhoneHeadset");
            DescriptionBuilder.AppendLine($"2 - PlayBackPhoneSpeaker");
            DescriptionBuilder.AppendLine($"3 - PlayBackSamsungHeadset");
            DescriptionBuilder.AppendLine($"4 - PlayBackUnofficialHeadset");
            DescriptionBuilder.AppendLine($"===========================================================");
            return DescriptionBuilder;
        }

        public int GetIndex(int index)
        {
            if (index > 0 && index < 5)
            {
                return index;
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(index)}");
            }
        }
    }
}
