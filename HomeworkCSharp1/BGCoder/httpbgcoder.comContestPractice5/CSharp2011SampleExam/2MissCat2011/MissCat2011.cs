using System;

class MissCat2011
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] catNumber = new int[10];

        int[] catVote = new int[n];
        int max=0;

        for (int i = 0; i < n; i++)
        {
            catVote[i] = int.Parse(Console.ReadLine());

            switch (catVote[i])
            {
                case 1:
                    {
                        catNumber[0]++;
                        break;
                    }
                case 2:
                    {
                        catNumber[1]++;
                        break;
                    }
                case 3:
                    {
                        catNumber[2]++;
                        break;
                    }
                case 4:
                    {
                        catNumber[3]++;
                        break;
                    }
                case 5:
                    {
                        catNumber[4]++;
                        break;
                    }
                case 6:
                    {
                        catNumber[5]++;
                        break;
                    }
                case 7:
                    {
                        catNumber[6]++;
                        break;
                    }
                case 8:
                    {
                        catNumber[7]++;
                        break;
                    }
                case 9:
                    {
                        catNumber[8]++;
                        break;
                    }
                case 10:
                    {
                        catNumber[9]++;
                        break;
                    }
                default:
                    break;
            }
        }
        for (int i = 0; i < 10; i++)
        {
            if (catNumber[i]>max)
            {
                max = catNumber[i]; 
            }  
        }
        for (int i = 0; i < n; i++)
        {
            if (catNumber[i]==max)
            {
                Console.WriteLine(i+1);
                break;
            }  
        }
    }
}
