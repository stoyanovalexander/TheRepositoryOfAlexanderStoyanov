using System;
    class ColloredRabits
    {
        static void Main()
        {
            int numOfAskedRabits = int.Parse(Console.ReadLine());
            int[] rabitAnswer = new int[numOfAskedRabits];
            for (int i = 0; i < rabitAnswer.Length; i++)
            {
                rabitAnswer[i] = int.Parse(Console.ReadLine());
            }
            
            int[] eachAnswerCount=new int[1000001];
            int indexOfAnswer = -8;
            for (int i = 0; i < rabitAnswer.Length; i++)
            {
                indexOfAnswer = rabitAnswer[i]+1;
                eachAnswerCount[indexOfAnswer]++;
            }

            int minCountRabits = 0;
            for (int i = 0; i < eachAnswerCount.Length; i++)
            {
                if (eachAnswerCount[i] > 0)
                {
                   int reminder=eachAnswerCount[i]%i;
                    if (reminder!=0)
                    {
                        minCountRabits = minCountRabits + (eachAnswerCount[i] / i) * i + i;
                    }
                    else
                    {
                        minCountRabits = minCountRabits + (eachAnswerCount[i] / i) * i ;
                    }
                }
            }

           
            Console.WriteLine(minCountRabits);
        }
    }

