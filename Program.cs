namespace homework2_1
{

    class program
    {
        static void Main(string[] args)
        {
            int check = 0;
            while (check == 0)
            {
                Console.WriteLine("Please input num of Pascal's Triangle : ");
                int numpascal = int.Parse(Console.ReadLine());
                if (numpascal >= 0)
                {
                    for (int i = 0; i <= numpascal; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            int coefficient = CalCoefficient(i, j);
                            Console.Write(coefficient + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Pascal's triangle row number.");

                }



            }


        }


        static int CalCoefficient(int row, int column)
        {
            if (column == 0 || column == row)
            {
                return 1;
            }
            else
            {
                int num = CalFactorial(row);
                int deno = CalFactorial(column) * CalFactorial(row - column);
                return num / deno;
            }
        }

        static int CalFactorial(int number)
        {
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }


    }
}
