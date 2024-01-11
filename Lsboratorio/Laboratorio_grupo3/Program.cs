namespace Laboratorio_grupo3
{
	internal class Program
	{
		class Pelicula
		{
			private String nombre;
			private int anio;

			public Pelicula(string nombre, int anio)
			{
				Nombre = nombre;
				Anio = anio;
				
			}

			public String Nombre
			{
				get { return nombre; }
				set { nombre = value; }
			}
			public int Anio
			{
				get { return anio; }
				set { anio = value; }
			}

			public void Mostrar()
			{
				Console.WriteLine("Nombre : " + nombre + "  Año : " + anio);
			}
		}
		class Nodo
		{
			private Pelicula dato;
			private Nodo siguiente;

			public Pelicula Dato
			{
				get { return dato; }
				set { dato = value; }
			}
			public Nodo Siguiente
			{
				get { return siguiente; }
				set { siguiente = value; }
			}
		}

		class ListaSimple
		{
			private Nodo primero = new Nodo();
			private Nodo ultimo = new Nodo();

			public ListaSimple()
			{
				primero = null;
				ultimo = null;
			}

			public void Insertar(Pelicula val)
			{
				Nodo nuevo = new Nodo();
				nuevo.Dato = val;
				if (primero != null)
				{
					ultimo.Siguiente = nuevo;
					nuevo.Siguiente = null;
					ultimo = nuevo;
				}
				else
				{
					primero = nuevo;
					primero.Siguiente = null;
					ultimo = nuevo;
				}
			}

			public int Contar()
			{
				Nodo actual = new Nodo();
				actual = primero;
				int num = 0;
				if (primero != null)
				{
					while (actual != null)
					{
						num++;
						actual = actual.Siguiente;
					}
					return num;
				}
				else
				{
					return 0;
				}
			}

			public void Ver()
			{
				Nodo actual = new Nodo();
				actual = primero;
				if (primero != null)
				{
					while (actual != null)
					{
						actual.Dato.Mostrar();
						//Console.WriteLine(actual.Dato);
						actual = actual.Siguiente;
					}
				}
				else
				{
					Console.WriteLine("No hay elementos en la lista");
				}
			}
		}

		static void Menu1(ListaSimple ls)
		{
			
			int op = 0;
			Console.WriteLine("*****************************");
			Console.WriteLine("        UNIVERSIDAD DE LAS FUERZAS ARMADAS (ESPE)        ");
			Console.WriteLine("        GRUPO #3        ");
			Console.WriteLine("        MENÚ PRINCIPAL        ");
			Console.WriteLine("1.- Ingresar el nombre y el año de la película.                ");
			Console.WriteLine("2.- Mostrar las películas ingresadas por el usuario.               ");
			Console.WriteLine("3.- Ordenar películas por nombre.                ");
			Console.WriteLine("4.- Ordenar películas por año.                ");
			Console.WriteLine("*******************************************************");
			Console.WriteLine();
			Console.WriteLine("Escriba el numero de la opcion que desea");
			if (int.TryParse(Console.ReadLine(), out op))
			{
				switch (op)
				{
					case 1:
						Console.WriteLine("Ingrese el nombre de la pelicula");
						String nombre_ = Console.ReadLine();
						Console.WriteLine("Ingrese el año de la pelicula");
						int anio_ = int.Parse(Console.ReadLine());
						Pelicula p1 = new Pelicula(nombre_,anio_);
						ls.Insertar(p1);
						Console.WriteLine("Pelicula ingresada con exito");
						Menu1(ls);
						break;
					case 2:
						Console.WriteLine("Las peliculas ingresadas son");
						Console.WriteLine();
						Console.WriteLine();
						ls.Ver();
						Console.WriteLine();
						Console.WriteLine();
						Menu1(ls);
						break;
					case 3:
						Menu2(ls,3);
						break;
					case 4:
						Menu2(ls,4);
						break;
					default:
						Console.WriteLine("Número no válido.");
						break;
				}
			}
			else
			{
				Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
			}
		}
		static void Menu2(ListaSimple ls,int num)
		{
			int op = 0;
			Console.WriteLine("***********************");
			Console.WriteLine("Ingrese el algoritmo con el que desea ordenar");
			Console.WriteLine("1.- Ordenar por Bubuja");
			Console.WriteLine("2.- Ordenar por Shell");
			Console.WriteLine("3.- Ordenar por Quick");
			Console.WriteLine("4.- Regresar");
			Console.WriteLine("***********************\n");
			Console.WriteLine("Escriba el numeo de la opcion que desea:");

			if (int.TryParse(Console.ReadLine(), out op))
			{
				switch (op)
				{
					case 1:
						Console.WriteLine("\nAlgoritmo Burbuja");
						if (num == 3)
						{

						}
						else
						{

						}
						break;
					case 2:
						Console.WriteLine("\nAlgoritmo Shell");
						if (num == 3)
						{

						}
						else
						{

						}
						break;
					case 3:
						Console.WriteLine("\nAlgoritmo Quick");
						if (num == 3)
						{

						}
						else
						{

						}
						break;
					case 4:
						Console.WriteLine("\nRegresando al menu anterior");
						Menu1(ls);
						break;
					default:
						Console.WriteLine("\nOpcion no valida, escoja una opcion del menu");
						break;
				}
			}
		}
		/////////////////
		////////    metodos
		public static void Shell(ListaSimple array)
		{
			int n = array.Contar();
			int gap = n / 2;

			while (gap > 0)
			{
				for (int i = gap; i < n; i++)
				{
					int temp = array[i];
					int j = i;

					while (j >= gap && array[j - gap] > temp)
					{
						array[j] = array[j - gap];
						j -= gap;
					}
					array[j] = temp;
				}
				gap /= 2;
			}
		}

		static void MostrarSellInt(int[] array)
		{
			foreach (var numero in array)
			{
				Console.Write(numero + " ");
			}
			Console.WriteLine();
		}
		
		///////// /
		static void Main(string[] args)
		{
			ListaSimple ls = new ListaSimple();
			Menu1(ls);

		}
	}
}
