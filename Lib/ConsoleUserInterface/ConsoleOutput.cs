using SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MyMobile.ClassLibrary.CommandLineUserInterface
{
    public class ConsoleOutput : IOutput
    {
        public void Write(string text)
        {
            Console.Write( text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public string ReturnSelectedOption(StringBuilder OptionBuilder, Exception Ex, int Index)
        {
            Console.WriteLine("***");
            if (Ex == null && OptionBuilder.Length > 0)
            {
                string[] Options = OptionBuilder.ToString().Replace("\r", "").Split('\n');
                string SelectedLine = Options[Index] + $" option was selected";
                return SelectedLine;
            }
            else
            {
                return "";
            }
        }

        public int ValidateUserInputIndex(int index, StringBuilder OptionBuilder)
        {
            int LastOption = OptionBuilder.ToString().Split('\n').Length - 2;

            if (index > 0 && index < LastOption)
            {
                return index;
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(index)}");
            }
        }

        //inherit this method as implementation is identical for inherited classes
        public int SelectComponentIndex()
        {
            while (true)
            {
                Console.WriteLine(BuildHeaderSelector());

                var OptionBuilder = BuildComponentsSelector();
                Console.Write(OptionBuilder);

                var line = Console.ReadLine();
                Exception Ex = null;
                int Index = 0;
                try
                {
                    //convert to integer
                    var index = int.Parse(line);
                    //check that int value is within the specified range of current method
                    //method inherited from abstract class - not unique
                    Index = ValidateUserInputIndex(index, OptionBuilder);
                    return Index;
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
                    //method inherited from abstract class - not unique
                    Console.WriteLine(ReturnSelectedOption(OptionBuilder, Ex, Index));
                }
            }
        }

        public virtual  StringBuilder BuildComponentsSelector()
        {
            var DescriptionBuilder = new StringBuilder();
            DescriptionBuilder.AppendLine($"===========================================================");
            DescriptionBuilder.AppendLine($"Default implementation");
            DescriptionBuilder.AppendLine($"===========================================================");
            return DescriptionBuilder;
        }

        public virtual StringBuilder BuildHeaderSelector()
        {
            var HeaderBuilder = new StringBuilder();
            HeaderBuilder.AppendLine($"===========================================================");
            HeaderBuilder.AppendLine($"Default implementation");
            HeaderBuilder.AppendLine($"===========================================================");
            return HeaderBuilder;
        }
    }
}
