using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public abstract class SelectComponent
    {
        public abstract StringBuilder GetComponents();
        public abstract StringBuilder GetHeader();

        public string ReturnSelectedOption(StringBuilder OptionBuilder, Exception Ex, int Index)
        {
            Console.WriteLine("***");
            if (Ex == null && OptionBuilder.Length > 0)
            {
                string[] Options = OptionBuilder.ToString().Replace("\r", "").Split("\n");
                string SelectedLine = Options[Index] + $" option was selected";
                return SelectedLine;
            }
            else
            {
                return "";
            }
        }

        public int ValidateIndex(int index, StringBuilder OptionBuilder)
        {
            int LastOption = OptionBuilder.ToString().Split("\n").Length-2;

            if (index > 0 && index < LastOption)
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
