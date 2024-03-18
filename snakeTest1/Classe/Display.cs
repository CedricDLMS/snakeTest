using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeTest1.Classe
{
    public class Display
    {
        public int maxWidth { get; set; }
        public int maxHeight { get; set; }
        public int[,] coordinateDisplayInts { get; private set; }
        public string[,] coordinateDisplayS { get; private set; }

        // Innitialise les coordonnées
        public void DisplayInitSize()
        {
            this.coordinateDisplayInts = new int[maxHeight, maxWidth];
            this.coordinateDisplayS = new string[maxHeight, maxWidth];
        }
        // Remplis tout les coordonnées avec des 0 pour vide et 1 pour bordure
        public void intsInnit()
        {
            for (int i = 0; i < this.coordinateDisplayInts.GetLength(0); i++)
            {
                for (int j = 0; j < this.coordinateDisplayInts.GetLength(1); j++)
                {
                    if (i == 0 || i == this.maxHeight - 1 || j == 0 || j == this.maxWidth - 1)
                    {
                        this.coordinateDisplayInts[i, j] = 1;
                    }
                    else
                    {
                        this.coordinateDisplayInts[i, j] = 0;
                    }
                }
            }
        }
        // actualise l'affichage en fonction du tableau des ints 
        public void displayConvert()
        {
            for (int i = 0; i < this.coordinateDisplayInts.GetLength(0); i++)
            {
                for (int j = 0; j < this.coordinateDisplayInts.GetLength(1); j++)
                {
                    // creer les bordures / murs quand ints = 1
                    if (coordinateDisplayInts[i, j] == 1)
                    {
                        coordinateDisplayS[i, j] = "#";
                    }
                    // creer le vide quand int = 0
                    if (coordinateDisplayInts[i, j] == 0)
                    {
                        coordinateDisplayS[i, j] = " ";
                    }
                }
            }
        }

        public void afficherEcran()
        {
            displayConvert();
            
            for (int i = 0; i < maxHeight; i++)
            {
                for (int j = 0; j < (maxWidth); j++)
                {
                    Console.Write(" " + coordinateDisplayS[i, j]);
                }
                Console.WriteLine();
            }
        }


        // Constructeurs 
        public Display() { }
        public Display(int MaxHeight, int MaxWidth)
        {
            this.maxHeight = MaxHeight;
            this.maxWidth = MaxWidth;
        }


    }
}
