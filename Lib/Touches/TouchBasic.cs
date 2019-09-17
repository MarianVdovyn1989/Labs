using System;
using System.Collections.Generic;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public abstract class TouchBasic
    {
        public string MultiTouchTechnology { get; }

        enum MultiTouchTech
        {
            Yes,
            No
        }
    }
}
