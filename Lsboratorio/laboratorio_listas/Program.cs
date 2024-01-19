using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace laboratorio_listas
{
	internal class Program
	{
		class Pelicula
		{
			private String nombre;
			private int anio;

			public Pelicula()
			{
				Nombre = null;
				Anio = 0;

			}
			public Pelicula(string nombre, int anio)
			{
				this.Nombre = nombre;
				this.Anio = anio;

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

		static void Menu1(List<Pelicula> ls)
		{

			int op = 0;
			Console.WriteLine("*********************************************************");
			Console.WriteLine("*    UNIVERSIDAD DE LAS FUERZAS ARMADAS (ESPE)          *");
			Console.WriteLine("*                GRUPO #3                               *");
			Console.WriteLine("*            MENÚ PRINCIPAL                             *");
			Console.WriteLine("* 1.- Ingresar el nombre y el año de la película.       *");
			Console.WriteLine("* 2.- Mostrar las películas ingresadas por el usuario.  *");
			Console.WriteLine("* 3.- Ordenar películas por nombre.                     *");
			Console.WriteLine("* 4.- Ordenar películas por año.                        *");
			Console.WriteLine("* 5.- Buscar peliculas por año.                                 *");
			Console.WriteLine("* 6.- Cerrar el programa	                               *");
			Console.WriteLine("*********************************************************");
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
						Pelicula p1 = new Pelicula(nombre_, anio_);
						ls.Add(p1);
						Console.WriteLine("Pelicula ingresada con exito");
						Menu1(ls);
						break;
					case 2:
						Console.WriteLine("Las peliculas ingresadas son");
						Console.WriteLine();
						Console.WriteLine();
						foreach (Pelicula elemento in ls)
						{
							elemento.Mostrar();
						}
						Console.WriteLine();
						Console.WriteLine();
						Menu1(ls);
						break;
					case 3:
						Menu2(ls, 3);
						break;
					case 4:
						Menu2(ls, 4);
						break;
					case 5:
						Menu3(ls, 5);
						break;
					case 6:
						break;
					default:
						
						Console.Clear();
						Console.WriteLine("Número no válido seleccione una de las opciones del Menu \n");
						Menu1(ls);
						break;
				}
			}
			else
			{
				Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
				Menu1(ls);
			}
		}

		static void Menu2(List<Pelicula> ls, int num)
		{
			int op = 0;
			Console.WriteLine("***********************");
			Console.WriteLine("Ingrese el algoritmo con el que desea ordenar");
			Console.WriteLine("1.- Ordenar por Bubuja");
			Console.WriteLine("2.- Ordenar por Shell");
			Console.WriteLine("3.- Ordenar por Quick");
			Console.WriteLine("4.- Regresar");
			Console.WriteLine("***********************\n");
			Console.WriteLine("Escriba el numero de la opcion que desea:");

			if (int.TryParse(Console.ReadLine(), out op))
			{
				switch (op)
				{
					case 1:
						Console.WriteLine("\nAlgoritmo Burbuja");
						if (num == 3)
						{
							BurbujaString(ls);
						}
						else
						{
							BurbujaInt(ls);
						}
						break;
					case 2:
						Console.WriteLine("\nAlgoritmo Shell");
						if (num == 3)
						{
							ShellString(ls);
							mostrar(ls);
						}
						else
						{
							ShellInt(ls);
							mostrar(ls);
						}
						break;
					case 3:
						Console.WriteLine("\nAlgoritmo Quick");
						if (num == 3)
						{
							QuickSortString(ls, 0, ls.Count - 1);

							foreach (Pelicula pelicula in ls)
							{
								pelicula.Mostrar();
							}
						}
						else
						{
							QuickSortPorAnio(ls, 0, ls.Count - 1);

							foreach (Pelicula pelicula in ls)
							{
								pelicula.Mostrar();
							}
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
		/////////////
		static void Menu3(List<Pelicula> ls, int num)
		{
			int op = 0;
			Console.WriteLine("*********************************************");
			Console.WriteLine("Ingrese el algoritmo de busqueda a utilizar:");
			Console.WriteLine("1.- Buscar por Secuencial");
			Console.WriteLine("2.- Buscar por Binario");
			Console.WriteLine("3.- Regresar");
			Console.WriteLine("*********************************************\n");
			Console.WriteLine("Escriba el numero de la opcion que desea:");

			if (int.TryParse(Console.ReadLine(), out op))
			{
				switch (op)
				{
					case 1:
						ShellInt(ls);
						int anioBusqueda = 0;
						do 
						{
							Console.WriteLine("\nAlgoritmo Secuencial");
							Console.WriteLine("Ingrese el año que desea buscar:");
							anioBusqueda = int.Parse(Console.ReadLine());
							if (anioBusqueda > 1895 && anioBusqueda < 2024)
							{
								
								BusquedaSecuencial(ls, anioBusqueda);
							}
							else
							{
								Console.WriteLine("Intervalo de año incorecto");
							}

						} while (anioBusqueda < 1895 && anioBusqueda > 2024) ;
						break;

					case 2:
						ShellInt(ls);
						int anioBinario = 0;
						do 
						{
							Console.WriteLine("\nAlgoritmo Binario");
							Console.WriteLine("Ingrese el año que desea buscar:");
							anioBinario = int.Parse(Console.ReadLine());
							if (anioBinario > 1895 && anioBinario < 2024)
							{
								int resultadoBinario = BusquedaBinaria(ls, anioBinario);

								if (resultadoBinario != -1)
								{
									Console.WriteLine($"Pelicula encontrada para el año {anioBinario}:");
									ls[resultadoBinario].Mostrar();
								}
								else
								{
									Console.WriteLine($"No se encontraron películas para el año {anioBinario}.");
								}
								Menu1(ls);
							}
							else
							{
								Console.WriteLine("Intervalo de año incorecto");
							}
						} while (anioBinario < 1895 && anioBinario > 2024) ;

						break;

					case 3:
						Console.WriteLine("\nRegresando al menu anterior");
						Menu1(ls);
						break;
					default:
						Console.Clear();
						Console.WriteLine("\nOpcion no valida, escoja una opcion del menu");
						Menu1(ls);
						break;
				}
			}
		}

		/////////////////
		////////    metodos
		///
		static List<Pelicula> QuickSortPorAnio(List<Pelicula> lista, int menor, int mayor)
		{
			int i = menor;
			int j = mayor;
			int pivote = lista[(menor + mayor) / 2].Anio;
			Pelicula temp;

			while (i <= j)
			{
				while (lista[i].Anio < pivote)
				{
					i++;
				}

				while (lista[j].Anio > pivote)
				{
					j--;
				}

				if (i <= j)
				{
					temp = lista[i];
					lista[i] = lista[j];
					lista[j] = temp;
					i++;
					j--;
				}
			}

			if (menor < j)
			{
				QuickSortPorAnio(lista, menor, j);
			}

			if (i < mayor)
			{
				QuickSortPorAnio(lista, i, mayor);
			}

			return lista;
		}

		static List<Pelicula> QuickSortString(List<Pelicula> lista, int menor, int mayor)
		{
			int i = menor;
			int j = mayor;
			string pivote = lista[(menor + mayor) / 2].Nombre;
			Pelicula temp;

			while (i <= j)
			{
				while (String.Compare(lista[i].Nombre, pivote, StringComparison.Ordinal) < 0)
				{
					i++;
				}

				while (String.Compare(lista[j].Nombre, pivote, StringComparison.Ordinal) > 0)
				{
					j--;
				}

				if (i <= j)
				{
					temp = lista[i];
					lista[i] = lista[j];
					lista[j] = temp;
					i++;
					j--;
				}
			}

			if (menor < j)
			{
				QuickSortString(lista, menor, j);
			}

			if (i < mayor)
			{
				QuickSortString(lista, i, mayor);
			}

			return lista;
		}

		static void BurbujaString(List<Pelicula> lista)
		{
			int n = lista.Count;
			bool intercambio;
			Pelicula temp;

			for (int i = 0; i < n - 1; i++)
			{
				intercambio = false;
				for (int j = 0; j < n - 1; j++)
				{
					if (string.Compare(lista[j].Nombre, lista[j + 1].Nombre) > 0)
					{
						temp = lista[j];
						lista[j] = lista[j + 1];
						lista[j + 1] = temp;
						intercambio = true;
					}
				}
				if (!intercambio)
					break;
			}

			foreach (Pelicula pelicula in lista)
			{
				pelicula.Mostrar();
			}
		}
		static void BurbujaInt(List<Pelicula> lista)
		{
			int n = lista.Count;
			bool intercambio;
			Pelicula temp;

			for (int i = 0; i < n - 1; i++)
			{
				intercambio = false;
				for (int j = 0; j < n - 1; j++)
				{
					if (lista[j + 1].Anio > 0)
					{
						temp = lista[j];
						lista[j] = lista[j + 1];
						lista[j + 1] = temp;
						intercambio = true;
					}
				}
				if (!intercambio)
					break;
			}

			foreach (Pelicula pelicula in lista)
			{
				pelicula.Mostrar();
			}
		}
		static void ShellString(List<Pelicula> lista)
		{
			int n = lista.Count;
			int gap = n / 2;

			while (gap > 0)
			{
				for (int i = gap; i < n; i++)
				{
					Pelicula temp = lista[i];
					int j = i;

					while (j >= gap && string.Compare(lista[j - gap].Nombre, temp.Nombre) > 0)
					{
						lista[j] = lista[j - gap];
						j -= gap;
					}
					lista[j] = temp;
				}
				gap /= 2;
			}
		}

		static void ShellInt(List<Pelicula> lista)
		{
			int n = lista.Count;
			int gap = n / 2;

			while (gap > 0)
			{
				for (int i = gap; i < n; i++)
				{
					Pelicula temp = lista[i];
					int j = i;

					while (j >= gap && lista[j - gap].Anio > temp.Anio)
					{
						lista[j] = lista[j - gap];
						j -= gap;
					}
					lista[j] = temp;
				}
				gap /= 2;
			}
		}

		static void BusquedaSecuencial(List<Pelicula> lista, int anioBusqueda)
		{
			Console.WriteLine($"Peliculas encontradas para el año {anioBusqueda}:");

			bool encontrado = false;

			foreach (var pelicula in lista)
			{
				if (pelicula.Anio == anioBusqueda)
				{
					pelicula.Mostrar();
					encontrado = true;
				}
			}

			if (!encontrado)
			{
				Console.WriteLine($"No se encontraron películas para el año {anioBusqueda}.");
			}

			Menu1(lista);
		}

		static int BusquedaBinaria(List<Pelicula> lista, int anioBuscado)
		{
			int izquierda = 0;
			int derecha = lista.Count - 1;

			while (izquierda <= derecha)
			{
				int medio = izquierda + (derecha - izquierda) / 2;

				if (lista[medio].Anio == anioBuscado)
					return medio;
				else if (lista[medio].Anio < anioBuscado)
					izquierda = medio + 1;
				else
					derecha = medio - 1;
			}
			return -1; 
		}


		static void mostrar(List<Pelicula> lista)
		{
			foreach (var numero in lista)
			{
				numero.Mostrar();
			}
			Console.WriteLine();
		}

		/// //////
	

		static void Main(string[] args)
		{
			Pelicula p1 = new Pelicula("Mulholland Drive", 2001);
			Pelicula p2 = new Pelicula("Fa yeung nin wa", 2000);
			Pelicula p3 = new Pelicula("There Will Be Blood", 2007);
			Pelicula p4 = new Pelicula("Boyhood", 2014);
			Pelicula p5 = new Pelicula("El árbol de la vida", 2011);
			List<Pelicula> ls = new List<Pelicula>();
			ls.Add(p1);
			ls.Add(p2);
			ls.Add(p3);	
			ls.Add(p4);
			ls.Add(p5);
			Menu1(ls);

		}
	}
}