using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class PlayBackSamsungHeadset : IPlayBack, IOutput
    {
        public PlayBackSamsungHeadset(IOutput output)
        {
            Output = output;
        }

        private IOutput Output;

        public void Play()
        {
            Output.WriteLine($"Play sound in Mobile:\n{nameof(PlayBackSamsungHeadset)} sound");
        }

        public void Write(string text)
        {
            Output.Write(text);
        }

        public void WriteLine(string text)
        {
            Output.WriteLine(text);
        }
    }
}
