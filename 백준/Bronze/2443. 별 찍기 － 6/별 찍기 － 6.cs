int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = num; j > i; j--)
                {
                    Console.Write("*");
                }
                for (int j = num-1; j > i; j--)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }