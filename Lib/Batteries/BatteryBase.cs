using System;
using System.Text;

namespace SimCorp.IMS.CSharpPrepCourse.Lab.MobilePhone
{
    public abstract class BatteryBase
    {
        public BatteryBase(int capacity)
        {
            Capacity = capacity;
        }      
        public int Capacity { get;}
    }
}