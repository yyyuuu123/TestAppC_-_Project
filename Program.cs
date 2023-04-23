// See https://aka.ms/new-console-template for more information
using TestApp;
using TestApp.Exeptions;
using TestApp.Extention;
using TestApp.Model;
using TestApp.Utils;

double area;

Figure shapeTringle = new Tringle(3, 4, 5);
area = shapeTringle.GetAreaFigure();

Figure shapeCicrle = new Circle(6);
area = shapeCicrle.GetAreaFigure();

/////Проверку на то, является ли треугольник прямоугольным 
///Тоже не совсем понятно с точки зрения моделирования что это должно быть.Утилитарный статический класс или интерфейс
///который реализует класс. 
Tringle tringle = (Tringle)shapeTringle;
bool getIsRightTrinle = tringle.CheckFigure(x => x.SideA * x.SideA + x.SideB * x.SideB == x.SideC * x.SideC);


////Вычисление площади фигуры без знания типа фигуры в compile-time
///
List<Figure> figures = new List<Figure>(2);
figures.Add(shapeTringle);
figures.Add(shapeCicrle);

foreach (Figure item in figures)
{
	try
	{
		double getShapeCompileTime = CompileTime<Figure>.GetInCompleTime(item);
        Console.WriteLine(getShapeCompileTime);
    }
	catch (NotFoundompileTime ex)
	{

		Console.WriteLine(ex.Output);
	}
}

