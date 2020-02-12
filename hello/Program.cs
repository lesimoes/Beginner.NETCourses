using System;

namespace hello
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            byte allocMemoryByte = 10;
            sbyte allocMemory = -10;

            //signed
            short shortNumber = -1100;

            //unsigned
            ushort uShortNumber = 100;

            int dogAge = 7;
            //unsigned
            uint onlyPositive = 10;

            long peopleLivingInMinas = 10000;
            ulong onlyPositiveLong = 10000;

            float dogHeigth = 1.3f;
            double dogWeigth = 9.2;
            decimal balanceAccount = 0.01m;
            char firstLetter = 'L';

            bool isDog = true;

            Console.WriteLine("Hello World! " + balanceAccount);

            Console.WriteLine("Cast Operator" + (double) 4 /3);

        }
    }
}
