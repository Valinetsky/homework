// Написать программу, которая из имеющегося массива строк 
// формирует массив строк, длина которых меньше, либо равна 3 символа. 

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []

string[] Array1 = { "hello", "2", "world", ":-)" };
string[] Array2 = { "1234", "1567", "-2", "computer science" };
string[] Array3 = { "Russia", "Denmark", "Kazan" };

string message = "Введите число символов для фильтрации массива";

int number = inputNumberPrompt(message);

string[] Arr1Fltered = ArrayFiltering(Array1, number);
ArrayPrint(Arr1Fltered);

string[] Arr2Fltered = ArrayFiltering(Array2, number);
ArrayPrint(Arr2Fltered);

string[] Arr3Fltered = ArrayFiltering(Array3, number);
ArrayPrint(Arr3Fltered);








// ------------------------ Filtering array items
string[] ArrayFiltering(string[] arrIn, int maxNumber)
{
	string[] arrOut = new string[] { };

	foreach (var item in arrIn)
	{
		if (item.Length <= maxNumber)
		{
			arrOut = arrOut.Append(item).ToArray();
		}
	}
	return arrOut;
}

// ------------------------ Array print
void ArrayPrint(string[] array)
{
	Console.Write("[ ");
	Console.Write("{0}", string.Join(" | ", array));
	Console.WriteLine(" ]");
}

// ------------------------ safe input int number
int inputNumberPrompt(string str)
{
	int number;
	string text;

	while (true)
	{
		Console.Write($"{str} ");
		text = Console.ReadLine();
		if (int.TryParse(text, out number))
		{
			break;
		}
		Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
	}
	return number;
}