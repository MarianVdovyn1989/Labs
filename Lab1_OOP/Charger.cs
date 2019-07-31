using System;
using System.Text;

namespace Lab1_OOP
{
    public interface ICharger
    {
        void Charge(object data);
        string Show();
        int GetIndex(int index);
    }

    public class WirelessCharge: Charger, ICharger
    {
        public void Charge(object data)
        {
            Console.WriteLine($"{nameof(WirelessCharge)} is enabled");
        }

        public string Show()
        {
            string result= $"{nameof(WirelessCharge)}";
            return result;
        }
    }

    public class FastCharge: Charger, ICharger
    {
        public void Charge(object data)
        {
            Console.WriteLine($"{nameof(FastCharge)} is enabled");
        }

        public string Show()
        {
            string result = $"{nameof(FastCharge)}";
            return result;
        }
    }

    public class RegularCharge : Charger, ICharger
    {
        public void Charge(object data)
        {
            Console.WriteLine($"{nameof(RegularCharge)} is enabled");
        }

        public string Show()
        {
            string result = $"{nameof(RegularCharge)}";
            return result;
        }
    }

    public abstract class Charger
    {
        public Charger()
        {
            Index = int.MinValue;
        }

        public int GetIndex(int index)
        {
            if (index>0 && index<4)
            {
                return index;
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(index)}");
            }
        }

        public int Index { get; set; }

    }
}