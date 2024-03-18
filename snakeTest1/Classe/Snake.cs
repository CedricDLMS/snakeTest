using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeTest1.Classe
{
    public class Snake
    {
        public int xPosHead {  get; set; }
        public int yPosHead { get; set; }
        public int snakeLenght {  get; set; }

        public void snakeInit(int ScreenHeight,int ScreenWidth)
        {
            this.xPosHead = (ScreenHeight-1)/2;
            this.yPosHead = (ScreenWidth-1)/2;
        }
        public void snakeInput(ConsoleKeyInfo consoleKey) 
        {
            if(consoleKey.Key == ConsoleKey.UpArrow)
            {
                 MoveUp();
            }
            if (consoleKey.Key == ConsoleKey.DownArrow)
            {
                MoveDown();
            }
            if (consoleKey.Key == ConsoleKey.LeftArrow)
            {
                MoveLeft();
            }
            if (consoleKey.Key == ConsoleKey.RightArrow)
            {
                MoveRight();
            }
        }
        public void MoveUp()
        {
            this.xPosHead += 1;
        }
        public void MoveDown()
        {
            this.xPosHead -= 1;
        }
        public void MoveRight()
        {
            this.yPosHead += 1;
        }
        public void MoveLeft()
        {
            this.yPosHead -= 1;
        }

        public Snake() { }
    }
}
