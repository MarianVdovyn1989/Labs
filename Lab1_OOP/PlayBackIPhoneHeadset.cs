using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class PlayBackIPhoneHeadset : IPlayBack
    {
        //public PlayBackIPhoneHeadset(IOutput output)
        //{
        //    Output = output;
        //}

        public void Play(object data)
        {
            Console.Write($"Play sound in Mobile: {nameof(PlayBackIPhoneHeadset)} sound");
        }

        //private IOutput Output;
    }
}
