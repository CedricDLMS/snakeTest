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
        public int[,] coordinateDisplayInts { get; private set ; }
        public string[,] coordinateDisplayS { get; private set; }

        // Innitialise les coordonnées
        public void DisplayInitSize() { 
            this.coordinateDisplayInts = new int[maxWidth, maxHeight];
            this.coordinateDisplayS = new string[maxWidth, maxHeight];
        }
        // Remplis tout les coordonnées avec des 0 pour vide
        public void intsInnit()
        {
            for (int i = 0; i < this.maxHeight; i++)
            {
                for (int j = 0; j < this.maxWidth; j++)
                {
                    this.coordinateDisplayInts[i, j] = 0;
                }
            }
        }


        // Constructeurs 
        public Display() { }
        public Display(int MaxWidth, int MaxHeight) 
        {
            this.maxWidth = MaxWidth;
            this.maxHeight = MaxHeight;
        }


    }
}
