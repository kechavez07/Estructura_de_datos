using System;
class NodoAVL
{
    public int Datos;
    public int Altura;
    public NodoAVL Izquierda, Derecha;

    public NodoAVL(int datos)
    {
        Datos = datos;
        Altura = 1;
    }
}

class ArbolAVL
{
    private NodoAVL raiz;

    private int ObtenerAltura(NodoAVL nodo)
    {
        if (nodo == null)
            return 0;
        return nodo.Altura;
    }

    private int ObtenerBalance(NodoAVL nodo)
    {
        if (nodo == null)
            return 0;
        return ObtenerAltura(nodo.Izquierda) - ObtenerAltura(nodo.Derecha);
    }
    //Rotaciones
    private NodoAVL RotarDerecha(NodoAVL y)
    {
        NodoAVL x = y.Izquierda; //creacion nuevo nodo
        NodoAVL T2 = x.Derecha;

        x.Derecha = y;
        y.Izquierda = T2;

        y.Altura = Math.Max(ObtenerAltura(y.Izquierda), ObtenerAltura(y.Derecha)) + 1;
        x.Altura = Math.Max(ObtenerAltura(x.Izquierda), ObtenerAltura(x.Derecha)) + 1;

        return x;
    }

    private NodoAVL RotarIzquierda(NodoAVL x)
    {
        NodoAVL y = x.Derecha;
        NodoAVL T2 = y.Izquierda;

        y.Izquierda = x;
        x.Derecha = T2;

        x.Altura = Math.Max(ObtenerAltura(x.Izquierda), ObtenerAltura(x.Derecha)) + 1;
        y.Altura = Math.Max(ObtenerAltura(y.Izquierda), ObtenerAltura(y.Derecha)) + 1;

        return y;
    }
    //
    private NodoAVL Insertar(NodoAVL nodo, int datos)
    {
        if (nodo == null)
            return new NodoAVL(datos);

        if (datos < nodo.Datos)
            nodo.Izquierda = Insertar(nodo.Izquierda, datos);
        else if (datos > nodo.Datos)
            nodo.Derecha = Insertar(nodo.Derecha, datos);

        ActualizarAltura(nodo);

        return Balancear(nodo);
    }

    private void ActualizarAltura(NodoAVL nodo)
    {
        if (nodo != null)
        {
            int alturaIzquierda = ObtenerAltura(nodo.Izquierda);
            int alturaDerecha = ObtenerAltura(nodo.Derecha);
            nodo.Altura = Math.Max(alturaIzquierda, alturaDerecha) + 1; //refleja la altura del camino más largo desde el nodo hasta una hoja.
        }
    }

    private NodoAVL Balancear(NodoAVL nodo)
    {
        int balance = ObtenerBalance(nodo);

        if (balance > 1)
        {
            if (ObtenerBalance(nodo.Izquierda) < 0) //subárbol derecho más alto
                nodo.Izquierda = RotarIzquierda(nodo.Izquierda);
            return RotarDerecha(nodo);
        }

        if (balance < -1)
        {
            if (ObtenerBalance(nodo.Derecha) > 0)
                nodo.Derecha = RotarDerecha(nodo.Derecha);
            return RotarIzquierda(nodo);
        }

        return nodo;
    }

    public void Insertar(int datos)
    {
        raiz = Insertar(raiz, datos);
    }

    private void RecorridoEnOrden(NodoAVL nodo)
    {
        if (nodo != null)
        {
            RecorridoEnOrden(nodo.Izquierda);
            Console.Write(nodo.Datos + " ");
            RecorridoEnOrden(nodo.Derecha);
        }
    }

    public void RecorridoEnOrden()
    {
        RecorridoEnOrden(raiz);
        Console.WriteLine();
    }
}

class Programa
{
    static void Main()
    {
        ProbarInsercionYRecorridoEnOrden();
        Console.ReadLine();
    }

    static void ProbarInsercionYRecorridoEnOrden()
    {
        ArbolAVL arbolAVL = new ArbolAVL();

        arbolAVL.Insertar(10);
        arbolAVL.Insertar(20);
        arbolAVL.Insertar(30);
        arbolAVL.Insertar(40);
        arbolAVL.Insertar(50);
        arbolAVL.Insertar(25);

        Console.WriteLine("Recorrido En Orden:");
        arbolAVL.RecorridoEnOrden(); // Debería imprimir: 10 20 25 30 40 50
    }
}
