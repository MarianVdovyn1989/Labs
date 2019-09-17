using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone.UI
{
    class TextBox : IOutput
    {
        private System.Windows.Forms.TextBox tbOutput;

        public TextBox(System.Windows.Forms.TextBox tb)
        {
            tbOutput = tb;
        }

        public void Write(string text)
        {
            tbOutput.AppendText(text);
        }

        public void WriteLine(string text)
        {
            tbOutput.AppendText(text);
            tbOutput.AppendText(Environment.NewLine);
        }
    }
}
