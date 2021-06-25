using System;

public class Class1
{
	public static void Main()
	{
		/*for (int counter = 0; counter < 10; counter++)
		{
			Console.WriteLine($"Hello World! The counter is {counter}");
		}

		int counterNames = 0;
		while (counterNames < 10)
		{
			Console.WriteLine($"Hello World! The counter is {counterNames}");
			counterNames++;
		}*/
		/*ALT ; con bloques*/
		/*CTRL+ALT+Pulsar para elegir varias lineas de codigocounterNames*/
		/*Puede buscar y reemplazar texto en el editor de Visual Studio mediante Buscar y reemplazar (Ctrl+F o Ctrl+H) o Find/Replace in Files (Buscar/Reemplazar en archivos) (Ctrl+Mayús+F o Ctrl+Mayús+H).*/
		//int counterOne = 0;
		/*do
		{
			Console.WriteLine($"Hello World! The counter is {counterOne}");
			counterOne++;
		} while (counterOne < 10);

		for (int row = 1; row < 11; row++)
		{
			Console.WriteLine($"The row is {row}");
		}

		for (int row = 1; row <5; row++)
		{
			for (char column = 'a'; column < 'h'; column++)
			{
				Console.WriteLine($"The cell is ({row}, {column})");
			}
		}

		int i;
		int j = 3;
		for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}"))
		{
			Console.WriteLine("---");
		}

		
		Console.WriteLine("///////////////");

		Class1 class1 = new Class1();

		int i;
		int j = 3;

        for (i=0, class1.startLoop(i,j); i < j; i++, j--, class1.stepLoop(i,j))
        {
			Console.WriteLine("---");
		}*/
		Console.WriteLine("///////////////");
		int i;
		int j = 3;
		Class1 class1 = new Class1();
		for (i = 0, class1.startLoop(i, j); i < j; i++, j--, class1.stepLoop(i, j))
		{
			Console.WriteLine("---");
		}
		Console.WriteLine("///////////////");
		var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
        foreach (int element in fibNumbers)
        {
			Console.Write($"{element}");
        }

	}

	public void startLoop(int i, int j)
    {
		Console.WriteLine($"Start: i={i}, j={j}");
	}
	public void stepLoop(int i, int j) => Console.WriteLine($"Step: i={i}, j={j}");

	
}
