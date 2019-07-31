using System;

namespace Lab1_OOP
{
    //not in use
    class Screen:ScreenSize
    {   
        public int Pixels { get { return Width * Height; }  }
    }
    //not in use
    public class ScreenSize
    {
        public ScreenSize()
        {
           Width = 0;
           Height = 0;
        }
        public int Width { get; set; }
        public int Height { get; set; }
    }


    public interface IScreenImage
    {
        int Size { get; set; }
        int Format { get; set; }       
    }

    //show functionality
    public abstract class ScreenBase
    {
        public abstract void Show(IScreenImage screenImage);
        public abstract void Show(IScreenImage screenImage, int brightness);
        public abstract string GetComponentType();
    }

    public class MonochromeScreen : ScreenBase
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine($"This is Monochrome Image");
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine($"This is Monochrome Image with level of brightness {brightness}");
        }

        public override string GetComponentType()
        {
            return "Monochrome Screen";
        }
    }

    public class ColorfulScreen : ScreenBase
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("here is logic for ColorfulScreen screen can be added");
        }

        public override void Show(IScreenImage screenImage, int brightness)
        {
            Console.WriteLine($"This is Colorful Image with level of brightness {brightness}");
        }

        public override string GetComponentType()
        {
            return "Colorful Screen";
        }
    }

    class RetinaScreen : ColorfulScreen
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("here is logic for Retina screen can be added");
        }

        public override string GetComponentType()
        {
            return "Retina Screen";
        }
    }

    class OLEDScreen : ColorfulScreen
    {
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("here is logic for OLED screen can be added");
        }

        public override string GetComponentType()
        {
            return "OLED Screen";
        }
    }

    //touch functionality
    class BasicTouch
    {
        public void BaseTouchResponse()
        {
            Console.WriteLine("ThisIsBasicTouchResponce");
        }
    }

    class SingleTouch : BasicTouch
    {
        public void SingleTouchResponse()
        {
            Console.WriteLine("ThisIsSingleTouchResponce");
        }
    }

    class MultiTouch : BasicTouch
    {
        public void MultiTouchResponse()
        {
            Console.WriteLine("ThisIsMultiTouchResponce");
        }
    }








}