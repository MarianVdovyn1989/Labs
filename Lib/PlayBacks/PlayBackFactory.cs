using Lib.PlayBacks;
using SimCorp.IMS.CSharpPrepCourse.Lab.MyMobile.ClassLibrary.CommandLineUserInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    

    public class PlayBackFactory:ConsoleOutput
    {
        public PlayBackFactory(IOutput output)
        {
            Output = output;
        }
        
        public IOutput Output;

        public IPlayBack Create(int soundOutputDevice)
        {
            switch (soundOutputDevice)
            {
                case 1:
                    return new PlayBackIPhoneHeadset(Output);
                case 2:
                    return new PlayBackPhoneSpeaker(Output);
                case 3:
                    return new PlayBackSamsungHeadset(Output);
                case 4:
                    return new PlayBackUnofficialHeadset(Output);
                // can't avoid default line as this method must return something so I created dummy class which return nothing
                default:
                    return new PlayBackDummy(Output);
            }
        }

        private void ShowSelectedOption(StringBuilder OptionBuilder, Exception Ex, int Index)
        {
            if (Ex == null && OptionBuilder.Length > 0)
            {
                string[] Options = OptionBuilder.ToString().Replace("\r", "").Split('\n');
                string SelectedLine = Options[Index] + $" option was selected";
                Console.WriteLine(SelectedLine);
            }
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

        public override StringBuilder BuildComponentsSelector()
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

        //methods inherited from abstract class - unique implementation
        public override StringBuilder BuildHeaderSelector()
        {
            var HeaderBuilder = new StringBuilder();
            HeaderBuilder.AppendLine($"===========================================================");
            HeaderBuilder.AppendLine($"Select PlayBack Component from the list below (specify index)");
            HeaderBuilder.AppendLine($"===========================================================");
            return HeaderBuilder;
        }
    }
}
