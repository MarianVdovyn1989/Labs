namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public abstract class ScreenBase
    {
        public ScreenBase(int height, int width, int colorDepth)
        {
            Height = height;
            Width = width;
            ColorDepth = colorDepth;
        }


        public int Height { get; }
        public int Width { get; }
        public int ColorDepth { get; }
    }
}
