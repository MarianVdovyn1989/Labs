using SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.PlayBacks
{
    class PlayBackDummy : IPlayBack, IOutput
    {
        public PlayBackDummy(IOutput output)
        {
            Output = output;
        }
        private IOutput Output;

        public void Play()
        {
            Output.WriteLine("");
        }

        public void Write(string text)
        {
            Output.WriteLine("");
        }

        public void WriteLine(string text)
        {
            Output.WriteLine("");
        }
    }
}
