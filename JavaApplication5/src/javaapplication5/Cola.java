package javaapplication5;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.LinkedList;
import java.util.Queue;


public class Cola implements ActionListener{
    Iu1 iu = new Iu1();
    Queue<String> cola1 = new LinkedList<>();

    public Cola(Iu1 interfas) {
        this.iu = interfas;
        this.iu.btnAnadir.addActionListener(this);
        this.iu.btnImprimir.addActionListener(this);
        
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == iu.btnAnadir) {
            System.out.println("se ingreso al boton");
            cola1.add("Documento");
            String conjunto = "";
            for (String a : cola1) {
                System.out.println(a);
                conjunto = conjunto + " " + a;
            }
            
            iu.jTextArea1.setText(conjunto);
        }
        if (e.getSource() == iu.btnImprimir) {
            // Obtener y eliminar el elemento al frente de la cola
            String elemento = cola1.poll();
            System.out.println("Elemento obtenido y eliminado: " + elemento);
            String conjunto = "";
            for (String a : cola1) {
                System.out.println(a);
                conjunto = conjunto + " " + a;
            }
            iu.jTextArea1.setText(conjunto);
        }
    }
}