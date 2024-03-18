// See https://aka.ms/new-console-template for more informatio
using snakeTest1.Classe;

Display ecran = new Display(30, 50);
Snake snake = new Snake();

snake.snakeInit(ecran.maxHeight, ecran.maxWidth);
ecran.DisplayInitSize();
ecran.intsInnit();
ecran.displayConvert();

ecran.coordinateDisplayInts[snake.xPosHead, snake.yPosHead] = 1;
ecran.displayConvert();

while (true)
{
    Console.Clear();
    ecran.afficherEcran();
    var key = Console.ReadKey();
    snake.snakeInput(key);
    ecran.coordinateDisplayInts[snake.xPosHead, snake.yPosHead] = 1;
}
