namespace metodo_busqueda_secuencial
{
	internal class Program
	{
		static int SequentialSearch(int[] array, int target)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == target)
					return i;
			}

			return -1;
		}

		static void PrintArray(int[] array)
		{
			foreach (var element in array)
			{
				Console.Write(element + " ");
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			int[] array = { 5, 2, 9, 1, 5, 6 };
			int target = 1;

			Console.WriteLine("Array:");
			PrintArray(array);

			int index = SequentialSearch(array, target);

			if (index != -1)
				Console.WriteLine($"\nEl elemento {target} se encuentra en la posición {index}.");
			else
				Console.WriteLine($"\nEl elemento {target} no se encuentra en el array.");
		}
	}
}
