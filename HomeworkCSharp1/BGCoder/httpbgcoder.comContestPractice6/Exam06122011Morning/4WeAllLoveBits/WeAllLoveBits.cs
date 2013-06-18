using System;

class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numberP = new int[n];
        int[] pFirstInversion = new int[n];
        int[] pSecondInversion = new int[n];
        int[] numberPNew = new int[n];

        for (int i = 0; i < numberP.Length; i++)
        {
            numberP[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numberP.Length; i++)
        {
            string bitwiseP = "";
            int stringValue;
            bool firstOne = false;
            for (int bit = 31; bit >= 0; bit--)
            {
                stringValue = (numberP[i] >> bit) & 1;

                if (stringValue == 1)
                {
                    firstOne = true;
                }
                if (firstOne)
                {
                    if (stringValue == 1)
                    {
                        bitwiseP = bitwiseP + "1";
                    }
                    else
                    {
                        bitwiseP = bitwiseP + "0";
                    }
                }
            }

            string firstInversion = "";
            string secondInversion = "";
            for (int reverce = 0; reverce < bitwiseP.Length; reverce++)
            {
                secondInversion = bitwiseP[reverce] + secondInversion;

                if (bitwiseP[reverce] == '0')
                {
                    firstInversion = firstInversion + "1";
                }
                else
                {
                    firstInversion = firstInversion + "0";
                }
            }

            //Console.WriteLine(firstInversion);
            //Console.WriteLine(secondInversion);
            int stepen = 1;
            for (int reverce = bitwiseP.Length - 1; reverce >= 0; reverce--)
            {

                pFirstInversion[i] = pFirstInversion[i] + stepen * ((int)firstInversion[reverce] - 48);
                pSecondInversion[i] = pSecondInversion[i] + stepen * ((int)secondInversion[reverce] - 48);
                stepen = stepen * 2;
                //pFirstInversion[i] = pFirstInversion[i] | ((int)firstInversion[bitwiseP.Length - (reverce + 1)] << reverce);
                //pSecondInversion[i] = pSecondInversion[i] | ((int)secondInversion[bitwiseP.Length - (reverce + 1)] << reverce);
            }

            //Console.WriteLine(pFirstInversion[i]);
            //Console.WriteLine(pSecondInversion[i]);

            numberPNew[i] = (numberP[i] ^ pFirstInversion[i]) & pSecondInversion[i];

            Console.WriteLine(numberPNew[i]);
        }

    }
}