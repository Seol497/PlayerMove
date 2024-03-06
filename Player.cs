using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PlayerMove
{
    internal class Player
    {
        private int playerX;
        private int playerY;
        private int newPlayerX;
        private int newPlayerY;

        public int PlayerX 
        {
            get
            {
                return playerX;
            }
            set 
            {
                playerX = value;
            }
        }
        public int PlayerY
        {
            get
            {
                return playerY;
            }
            set
            {
                playerY = value;
            }
        }

        public void Move(ConsoleKeyInfo keyInfo, int[,] map)
        {
            newPlayerX = playerX;
            newPlayerY = playerY;

            //Player Move
            if (keyInfo.Key == ConsoleKey.W ||
                keyInfo.Key == ConsoleKey.UpArrow)
            {
                newPlayerY--;
            }

            if (keyInfo.Key == ConsoleKey.S ||
                keyInfo.Key == ConsoleKey.DownArrow)
            {
                newPlayerY++;
            }

            if (keyInfo.Key == ConsoleKey.A ||
                keyInfo.Key == ConsoleKey.LeftArrow)
            {
                newPlayerX--;
            }

            if (keyInfo.Key == ConsoleKey.D ||
                keyInfo.Key == ConsoleKey.RightArrow)
            {
                newPlayerX++;
            }

            //predict
            if (map[newPlayerY, newPlayerX] == 1)
            {
                newPlayerX = playerX;
                newPlayerY = playerY;
            }

            else if (map[newPlayerY, newPlayerX] == 2)
            {
                Goal();               
            }

            playerX = Math.Clamp(newPlayerX, 0, 80);
            playerY = Math.Clamp(newPlayerY, 0, 20);
        }

        public void Render()
        {
            Console.SetCursorPosition(playerX,
                playerY);
            Console.Write('P');
        }

    }
}
