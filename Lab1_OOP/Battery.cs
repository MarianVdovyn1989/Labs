using System;
using System.Text;

namespace Lab1_OOP
{
    public abstract class Battery
    {
        public Battery(int capacity, bool wirelessCharge, bool fastCharge)
        {
            Capacity = capacity;
            WirelessCharge = wirelessCharge;
            FastCharge = fastCharge;
        }

        public abstract string GetComponentType();

        int Capacity { get; set; }
        bool WirelessCharge { get; }
        bool FastCharge { get; }
        string WirelessChargeText
        {
            get
            {
                switch (WirelessCharge)
                {
                    case bool y when y == true:
                        return "Yes";
                    default:
                        return "No";
                }

            }
            
        }
        string FastChargeText
        {
            get
            {
                switch (FastCharge)
                {
                    case bool y when y == true:
                        return "Yes";
                    default:
                        return "No";
                }
            }

        }
        


    }

    class NickelCadmium : Battery
    {
        public NickelCadmium(int capacity, bool wirelessCharge, bool fastCharge):base(capacity, wirelessCharge, fastCharge)
        {
        }

        public override string GetComponentType()
        {
            return "NickelCadmium";
        }
    }

    class NiMH : Battery
    {
        public NiMH(int capacity, bool wirelessCharge, bool fastCharge) : base(capacity, wirelessCharge, fastCharge)
        {
        }

        public override string GetComponentType()
        {
            return "NiMH";
        }
    }

    class LithiumIon : Battery
    {
        public LithiumIon(int capacity, bool wirelessCharge, bool fastCharge) : base(capacity, wirelessCharge, fastCharge)
        {
        }

        public override string GetComponentType()
        {
            return "LithiumIon";
        }
    }

    class LithiumPolymer : Battery
    {
        public LithiumPolymer(int capacity, bool wirelessCharge, bool fastCharge) : base(capacity, wirelessCharge, fastCharge)
        {
        }

        public override string GetComponentType()
        {
            return "LithiumPolymer";
        }
    }
}