namespace Metodo_QuickSort
{
	internal class Program
	{
		static void QuickSort(int[] array, int low, int high)
		{
			if (low < high)
			{
				int partitionIndex = Partition(array, low, high);

				QuickSort(array, low, partitionIndex - 1);
				QuickSort(array, partitionIndex + 1, high);
			}
		}

		static int Partition(int[] array, int low, int high)
		{
			int pivot = array[high];
			int i = low - 1;

			for (int j = low; j < high; j++)
			{
				if (array[j] < pivot)
				{
					i++;
					Swap(array, i, j);
				}
			}

			Swap(array, i + 1, high);
			return i + 1;
		}

		static void Swap(int[] array, int i, int j)
		{
			int temp = array[i];
			array[i] = array[j];
			array[j] = temp;
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

			Console.WriteLine("Array original:");
			PrintArray(array);

			QuickSort(array, 0, array.Length - 1);

			Console.WriteLine("\nArray ordenado:");
			PrintArray(array);
		}
	}
}
