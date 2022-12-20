using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GIVE ME FIRST NUMBER ");
            int N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("GIVE ME SECOND NUMBER ");
            int N2 = int.Parse(Console.ReadLine());
            int M;
            int K;
            int C;
            Console.Write("The perfect numbers between {0} and {1} are : \n", N1, N2);


            for (M = N1; M <= N2; M++)
            {
                K = 0;


                for (C = 1; C < M; C++)
                {

                    if (M % C == 0)
                    {
                        K += C;



                    }
                }

                if (K == M)

                    Console.WriteLine(M);

            }
        }
    }
}
