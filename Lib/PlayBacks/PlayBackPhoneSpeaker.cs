using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class PlayBackPhoneSpeaker : IPlayBack, IOutput
    {
        public PlayBackPhoneSpeaker(IOutput output)
        {
            Output = output;
        }  
        private IOutput Output;


        public void Play()
        {
            Output.WriteLine($"Play sound in Mobile:\n{nameof(PlayBackPhoneSpeaker)} sound");
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
