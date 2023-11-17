
package javaapplication5;

import java.util.LinkedList;
import java.util.Queue;


public class JavaApplication5 {


    public static void main(String[] args) {
        
        Queue<String> cola = new LinkedList<>();
        
        Iu1 ui = new Iu1();
        ui.setVisible(true);
        cola.add("Elemento 1");
        cola.add("Elemento 2");
        cola.add("Elemento 3");
        
           // Obtener y eliminar el elemento al frente de la cola
        String elemento = cola.poll();
        System.out.println("Elemento obtenido y eliminado: " + elemento);

        // Mostrar todos los elementos de la cola
        System.out.println("Elementos en la cola:");
        for (String e : cola) {
            System.out.println(e);
        }
    }
    
}
