#include <iostream>
using namespace std;

// Función recursiva para calcular el número de Fibonacci
int Fibonacci(int n) {
    if (n <= 1) {
        return n;
    }
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

// Función recursiva para calcular el coeficiente binomial (C(n, r))
int Calcula(int n, int r) {
    if (r == 0 || r == n) {
        return 1;
    } else {
        return Calcula(n - 1, r - 1) + Calcula(n - 1, r);
    }
}

// Función para encontrar el índice del elemento más pequeño en un rango
int encontrarIndiceDelMinimo(int arr[], int inicio, int fin) {
    int indiceMinimo = inicio;
    for (int i = inicio + 1; i < fin; i++) {
        if (arr[i] < arr[indiceMinimo]) {
            indiceMinimo = i;
        }
    }
    return indiceMinimo;
}

// Función para intercambiar dos elementos de un arreglo
void intercambiar(int& a, int& b) {
    int temp = a;
    a = b;
    b = temp;
}

// Función recursiva para ordenar un arreglo de enteros de menor a mayor
void ordenarArreglo(int arr[], int n, int inicio = 0) {
    if (inicio < n - 1) {
        int indiceMinimo = encontrarIndiceDelMinimo(arr, inicio, n);
        intercambiar(arr[inicio], arr[indiceMinimo]);
        ordenarArreglo(arr, n, inicio + 1);
    }
}

int main() {
    int num = 6;
    int n = 7; // Número de elementos en el arreglo
    int r = 2;
    int arr[] = {5, 2, 8, 1, 9, 3, 6};

    cout<<'\n';
    cout << "EJERCICIO 1" << endl;
    cout << "Numero de Fibonacci de " << num << " es: " << Fibonacci(num) << endl;

    cout<<'\n';
    cout << "EJERCICIO 2" << endl;

    int resultado = Calcula(n, r);
    cout << "C(" << n << ", " << r << ") = " << resultado << endl;

    cout<<'\n';
    cout << "EJERCICIO 3" << endl;
    ordenarArreglo(arr, n);
    cout << "Arreglo ordenado de menor a mayor: ";
    for (int i = 0; i < n; i++) {
        cout << arr[i] << " ";
    }
     return 0;
}

