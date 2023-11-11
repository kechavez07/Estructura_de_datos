//Ejercicio 7: Transformcion de numero entero a notacion binaria

#include <iostream>

void bin(int n){
        if (n > 0){
            bin(n / 2);
        }
        std::cout<<n % 2;
}

int main (int num) {
    std::cout<<"Numero: ";
    std::cin>>num;
    
    std::cout<<"La notacion binaria es: ";
    bin(num);
    
    return 0;
}

//Ejercicio 8: Tranformacion de notacion binaria a numero entero

#include <iostream>

int dec(int bin){
    if(bin == 0){
        return 0;
    } else {
        return bin % 10 + 2 * dec(bin / 10);
    }
}

int main(int bin) {
    std::cout << "Numero binario: ";
    std::cin >> bin;
    
    std::cout <<"El numero decimal es: "<< dec(bin)<< std::endl;
    return 0;
}

//Ejercicio 9: Suma de un arreglo de numeros enteros

#include <iostream>

int sumaArr(int arr[], int cant) {
    if (cant == 0) {
        return 0;
    }else{
        return arr[cant - 1] + sumaArr(arr, cant - 1);
    }
}

int main() {
    int arr[] = {3, 4, 5, 6 ,7};
    int cant = sizeof(arr) / sizeof(arr[0]);

    std::cout << "La suma del arreglo es: " << sumaArr(arr, cant) << std::endl;

    return 0;
}
