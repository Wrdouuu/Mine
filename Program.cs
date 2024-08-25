using System;

namespace MINE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Map height:");
            int a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Map length:");
            int b = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter Map:");
            char[,] map = new char[a,b];

            for(int height =0; height<a;height++)
            {
                string hangngang = Console.ReadLine();
                char[] cacphantu = hangngang.ToCharArray();
                for (int length = 0; length < b; length++)
                {
                    map[height,length]= cacphantu[length];
                }
            }
            for(int height =0; height<a;height++)
            {
                for (int length = 0; length < b; length++)
                {
                     int[,] surround =
                     {
                        {height - 1, length - 1},
                        {height - 1, length},
                        {height - 1, length + 1},
                        {height, length - 1},
                        {height, length + 1},
                        {height + 1, length - 1},
                        {height + 1, length},
                        {height + 1, length + 1}
                     };
                     if (map[height,length] != '*')
                     {
                        map[height,length] = '0';
                        for (int nearby = 0; nearby < surround.GetLength(0); nearby++)
                        {
                            int a0 = surround[nearby, 0];
                            int b0 = surround[nearby, 1];
                            bool insideMap = a0 >= 0 && a0 < a && b0 >= 0 && b0 < b;
                            if (insideMap && map[height,length] == '*')
                            {
                                map[height,length]++;
                            }
                        }
                     }
                }
            }
            for (int height = 0; height < a; height++)
            {
                Console.WriteLine();
                for (int length = 0; length < b; length++)
                {
                    Console.WriteLine(map[height,length]);
                }
            }


    

        }
    }
}
