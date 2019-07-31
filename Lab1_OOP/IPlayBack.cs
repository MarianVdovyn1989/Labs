using System;

namespace Lab1_OOP
{
    public interface IPlayBack
    {
        void Play(object data); 
    }

    public class IPhoneHeadset: IPlayBack
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(IPhoneHeadset)} sound");
        }
    }
    public class SamsungHeadset : IPlayBack
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(SamsungHeadset)} sound");
        }
    }
    public class UnofficialHeadset : IPlayBack
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(UnofficialHeadset)} sound");
        }
    }
    public class PhoneSpeaker : IPlayBack
    {
        public void Play(object data)
        {
            Console.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}