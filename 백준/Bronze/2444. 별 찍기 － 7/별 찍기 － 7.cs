int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = num - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < num-1; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = num-1; j > i; j--)
                {
                    Console.Write("*");
                }
                for (int j = num-2; j > i; j--)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }