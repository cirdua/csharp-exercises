// See https://aka.ms/new-console-template for more information

namespace csharpModule
{
    class module {

        public static void numberOne(int level)
        {
            for(int i = 0; i < level; ++i)
            {
                if (i == 0)
                {
                    System.Console.WriteLine("*");
                }
                else
                {
                    System.Console.Write("*");
                    for (int j = 2; j <= i; j++)
                    {
                        if (i == level - 1)
                        {
                            System.Console.Write("*");
                        }
                        else
                        {
                            System.Console.Write(" ");
                        }
                    }
                    System.Console.WriteLine("*");
                }
            }
            return;
        }

        public static void numberTwo(int level)
        {
            int base_level = 1;
            for (int i = 1; i < level; ++i)
            {
                base_level += 2;

            }

            int spaces = base_level - 1;
            int stars = 1;

            if (level == 1)
            {
                System.Console.WriteLine("*");
            }
            else
            {
                for (int j = 0; j < level; ++j)
                {
                    for (int k = 0; k < (spaces)/2; ++k)
                    {
                        System.Console.Write(" ");
                    }

                    for (int l = 0; l < stars; ++l)
                    {
                        System.Console.Write("*");
                    }

                    for (int k = 0; k < (spaces)/2; ++k)
                    {
                        System.Console.Write(" ");
                    }
                    System.Console.Write("\n");
                    spaces -= 2;
                    stars += 2;
                }
                System.Console.Write("\n");
            }

            return;
        }

        public static int numberThree(int first,int second)
        {
            int result = first + second;
            System.Console.WriteLine("#3 Result: {0}", result);
            return result;
        }

        public static float numberFour(float first, float second)
        {
            float result = first * second;
            System.Console.WriteLine("#4 Result: {0}", result);
            return result;
        }

        public static int numberFive(int[] input)
        {
            int result = 0;
            foreach (int number in input)
            {
                result += number;
            }

            int average = result/input.Length;
            System.Console.WriteLine("#5 Average: {0}", average);
            return average;
        }

        public static void numberSix(int number)
        {
            if (number % 2 == 0 )
            {
                System.Console.WriteLine("#6 Even");
            }
            else
            {
                System.Console.WriteLine("#6 Odd");
            }
            return;
        }

        public static void numberSeven(int[] input)
        {
            int result = 0;
            foreach (int number in input)
            {
                result += number;
            }

            int average = result/input.Length;
            List<int> above_list = new List<int>();
            List<int> below_list = new List<int>();
            List<int> equal_list = new List<int>();

            foreach (int number in input)
            {
                if (number > average)
                {
                    above_list.Add(number);
                }
                else if (number < average)
                {
                    below_list.Add(number);
                }
                else
                {
                    equal_list.Add(number);
                }
            }

            System.Console.Write("#7 Numbers above the average: ");
            foreach (int number in above_list)
            {
                System.Console.Write("{0} ", number);
            }
            System.Console.WriteLine("");

            System.Console.Write("#7 Numbers below the average: ");
            foreach (int number in below_list)
            {
                System.Console.Write("{0} ", number);
            }
            System.Console.WriteLine("");

            System.Console.Write("#7 Numbers equal to the average: ");
            foreach (int number in equal_list)
            {
                System.Console.Write("{0} ", number);
            }
            System.Console.WriteLine("");

            return;
        }

        public static void numberEight()
        {
            for (int i = 1; i <= 10; ++i)
            {
                System.Console.WriteLine("{0}",i);
            }
            return;
        }

       public static void numberNine(int[] input)
        {
            // Same as #7
            int result = 0;
            foreach (int number in input)
            {
                result += number;
            }

            int average = result/input.Length;
            List<int> above_list = new List<int>();
            List<int> below_list = new List<int>();
            List<int> equal_list = new List<int>();

            foreach (int number in input)
            {
                if (number > average)
                {
                    above_list.Add(number);
                }
                else if (number < average)
                {
                    below_list.Add(number);
                }
                else
                {
                    equal_list.Add(number);
                }
            }

            System.Console.Write("#9 Numbers above the average: ");
            foreach (int number in above_list)
            {
                System.Console.Write("{0} ", number);
            }
            System.Console.WriteLine("");

            System.Console.Write("#9 Numbers below the average: ");
            foreach (int number in below_list)
            {
                System.Console.Write("{0} ", number);
            }
            System.Console.WriteLine("");

            System.Console.Write("#9 Numbers equal to the average: ");
            foreach (int number in equal_list)
            {
                System.Console.Write("{0} ", number);
            }
            System.Console.WriteLine("");

            return;
        }
        public static void numberTen(String name,String section)
        {
            System.Console.WriteLine("Name: {0}\nSection: {1}", name, section);
            return;
        }
        static void Main(string[] args)
        {
            module.numberOne(10);
            module.numberTwo(10);
            module.numberThree(1, 2);
            module.numberFour((float)1.1, (float)2.2);
            module.numberFive(new int[] {1,2,3,5});
            module.numberSix(2);
            module.numberSeven(new int[] {1,2,3});
            module.numberEight();
            module.numberNine(new int[] {1,2,3});
            module.numberTen("Anna", "CE");
        }
    }
}