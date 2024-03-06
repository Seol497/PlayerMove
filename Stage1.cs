using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMove
{

    internal class Stage
    {
       private int[,] firMap =
            {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,},
                { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1,},
                { 1, 0, 1, 0, 1, 0, 1, 1, 0, 1,},
                { 1, 0, 1, 0, 1, 0, 1, 1, 0, 1,},
                { 1, 0, 1, 0, 0, 0, 1, 1, 0, 1,},
                { 1, 0, 1, 0, 1, 1, 1, 1, 0, 2,},
                { 1, 0, 1, 0, 1, 0, 1, 1, 0, 1,},
                { 1, 0, 1, 0, 1, 0, 1, 1, 0, 1,},
                { 1, 0, 0, 0, 1, 0, 0, 0, 0, 1,},
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,},
            };
        private int[,] secMap =
           {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,},
                { 1, 0, 1, 0, 0, 0, 0, 0, 0, 1,},
                { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1,},
                { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1,},
                { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1,},
                { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1,},
                { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1,},
                { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1,},
                { 1, 0, 0, 0, 1, 0, 0, 0, 0, 2,},
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,},
            };
        private int[,] map;

        public int[,] Map
        {
            get
            {
                return map = firMap;
            }
            set
            {
                map = value;
            }
        }
        public void Render()
        {
            Console.Clear();
            //Render Map
            for (int y = 0; y < 10; ++y)
            {
                for (int x = 0; x < 10; ++x)
                {
                    Console.SetCursorPosition(x, y);
                    if (map[y, x] == 1)
                    {
                        Console.Write('*');
                    }
                    else if (map[y, x] == 0)
                    {
                        Console.Write(' ');
                    }
                    else if (map[y, x] == 2)
                    {
                        Console.WriteLine("0");
                    }
                }
            }
        }
    }
}
