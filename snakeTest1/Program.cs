// See https://aka.ms/new-console-template for more informatio
using snakeTest1.Classe;

Display ecran = new Display(20,40);

ecran.DisplayInitSize();


for (int i = 0;i < 20; i++)
{
    Console.WriteLine();
    for (int j = 0;j < 40; j++)
    {
        Console.Write($" {ecran.coordinateDisplayInts[i,j]}");
    }
}
