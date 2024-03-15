using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeTest1.Classe
{
    internal class Display
    {
        public int maxWidth { get; set; }
        public int maxHeight { get; set; }
        public int[,] coordinateDisplay { get; private set ; }

        public void DisplayInit() { 
            this.coordinateDisplay = new int[maxWidth, maxHeight];
        }
        
        
    }
}
