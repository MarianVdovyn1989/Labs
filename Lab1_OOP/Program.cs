using System;

namespace Lab1_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            SimCorpMobile MyMobile = new SimCorpMobile();

            //battary and screen
            string description = MyMobile.GetDescription();
            Console.WriteLine(description);
            Console.ReadLine();

            SelectChargeComponent(MyMobile);
        }

        public static void SelectChargeComponent(SimCorpMobile myMobile)
        {



            while (true)
            {
                Console.WriteLine($"Select Charge Component from the list below (specify index)");
                Console.WriteLine($"======================================================");

                ListChargeTypes();

                var line = Console.ReadLine();
                try
                {
                    var index = int.Parse(line);
                    myMobile.GetIndex(index);
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("***");
                }
            }
        }
        public static void ListChargeTypes()
        {
            FastCharge ChargerF = new FastCharge();
            WirelessCharge ChargerW = new WirelessCharge();
            RegularCharge ChargerR = new RegularCharge();

            Console.WriteLine($"1 - {ChargerF.Show()}");
            Console.WriteLine($"2 - {ChargerW.Show()}");
            Console.WriteLine($"3 - {ChargerR.Show()}");
            Console.WriteLine($"=====================");

        }
    }
}
