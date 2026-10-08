using System;

class Program
{
    static void targil1()
    {
        double[] grades = new double[10];
        double sum = 0;

        for (int i = 0; i < 10; i++)
        {
            grades[i] = double.Parse(Console.ReadLine());
            sum += grades[i];
        }

        double avg = sum / 10;

        for (int i = 0; i < 10; i++)
        {
            double distance = Math.Abs(grades[i] - avg);
            Console.WriteLine(distance);
        }
    }

    static void targil2()
    {
        string results = Console.ReadLine();
        string guesses = Console.ReadLine();
        int correct = 0;

        for (int i = 0; i < 15; i++)
        {
            if (results[i] == guesses[i])
            {
                correct++;
            }
        }

        Console.WriteLine(correct);
    }

    static void targil3()
    {
        int[] arr = new int[14];
        for (int i = 0; i < 14; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int maxVal = arr[0];
        int maxIndex = 0;

        for (int i = 1; i < 14; i++)
        {
            if (arr[i] > maxVal)
            {
                maxVal = arr[i];
                maxIndex = i;
            }
        }

        Console.WriteLine(maxVal);
        Console.WriteLine(maxIndex);
    }

    static void targil4()
    {
        double[] M = new double[60];
        double[] N = new double[20];

        for (int i = 0; i < 60; i++)
        {
            M[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 20; i++)
        {
            double num1 = M[i * 3];
            double num2 = M[i * 3 + 1];
            double op = M[i * 3 + 2];
            double res = 0;

            if (op == 1)
            {
                res = num1 + num2;
            }
            else if (op == 2)
            {
                res = num1 - num2;
            }
            else if (op == 3)
            {
                res = num1 * num2;
            }
            else if (op == 4)
            {
                res = num1 / num2;
            }

            N[i] = res;
        }

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(N[i]);
        }
    }

    static void targil5()
    {
        int[] arr = new int[40];
        for (int i = 0; i < 40; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);

        int cumulativeSum = 0;
        int input = int.Parse(Console.ReadLine());

        while (input != -1)
        {
            cumulativeSum += input;
            int index = Array.BinarySearch(arr, input);

            if (index >= 0)
            {
                Console.WriteLine(index + " " + cumulativeSum);
            }
            else
            {
                int bitwiseIndex = ~index;
                Console.WriteLine(bitwiseIndex + " " + cumulativeSum);
            }

            input = int.Parse(Console.ReadLine());
        }
    }

    static void targil6()
    {
        bool[] seats = new bool[200];

        for (int i = 0; i < 200; i++)
        {
            int requested = int.Parse(Console.ReadLine()) - 1;
            int finalSeat = -1;

            if (!seats[requested])
            {
                finalSeat = requested;
            }
            else
            {
                int dist = 1;
                while (true)
                {
                    int down = requested - dist;
                    int up = requested + dist;

                    if (down >= 0 && !seats[down])
                    {
                        finalSeat = down;
                        break;
                    }
                    if (up < 200 && !seats[up])
                    {
                        finalSeat = up;
                        break;
                    }
                    dist++;
                }
            }

            seats[finalSeat] = true;
            Console.WriteLine(finalSeat + 1);
        }
    }

    static void targil7()
    {
        double[] july = new double[31];
        double[] august = new double[31];
        double julySum = 0;
        double augustSum = 0;

        for (int i = 0; i < 31; i++)
        {
            july[i] = double.Parse(Console.ReadLine());
            julySum += july[i];
        }

        for (int i = 0; i < 31; i++)
        {
            august[i] = double.Parse(Console.ReadLine());
            augustSum += august[i];
        }

        double julyAvg = julySum / 31.0;
        double augustAvg = augustSum / 31.0;

        if (augustAvg <= julyAvg * 0.75)
        {
            Console.WriteLine("יש שיפור משמעותי במספר הניתוקים");
        }
        else
        {
            Console.WriteLine("אין שיפור משמעותי במספר הניתוקים");
        }
    }

    static void Main(string[] args)
    {

    }
}