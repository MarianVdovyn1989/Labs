using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public class PlayBackSamsungHeadset : IPlayBack
    {
        public void Play(object data)
        {
            Console.Write($"Play sound in Mobile: {nameof(PlayBackSamsungHeadset)} sound");
        }
    }
}
