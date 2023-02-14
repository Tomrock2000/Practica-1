using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
       
        Vector my_vector = new Vector(5,2,6,3);
        Vector my_vector_2 = new Vector(1,2,4,3);
        float scalar = 3;

        //Llamado a operador "-"
        Vector my_vector_3 = my_vector - my_vector_2;
        Console.WriteLine($"Mi magnitud es de: {my_vector_3.get_magnitud()} (Resta)");

        /* Llamado a multiplicación por un escalar (No estaba seguro de qué operador usar, así que utilicé 
        Multiply() para realizar la operación)*/

        my_vector_3 = Vector.Multiply(my_vector, scalar);
        Console.WriteLine($"Mi magnitud es de: {my_vector_3.get_magnitud()} (Multiplicacion por escalar)");

        //Llamado a operador "*"
        my_vector_3 = my_vector * my_vector_2;
        Console.WriteLine($"Mi magnitud es de: {my_vector_3.get_magnitud()} (Multiplicacion de vectores producto punto)");


        Console.ReadLine();
    }
}
