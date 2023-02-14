using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Vector
{
    Punto origen;
     Punto fin;
    double magnitud;

    public Vector()
    {
        origen = new Punto(0, 0);
        fin = new Punto(1, 1);
        calcular_magnitud();
    }
    public Vector(Punto _origen, Punto _fin)
    {
        origen = new Punto(_origen.GetX(), _origen.GetY());
        fin = new Punto(_fin.GetX(), _fin.GetY());
        calcular_magnitud();
    }
    public Vector(float x_origen, float y_origen, float x_fin, float y_fin)
    {
        origen = new Punto(x_origen, y_origen);
        fin = new Punto(x_fin, y_fin);
        calcular_magnitud();
    }
    private void calcular_magnitud()
    {
        magnitud = Math.Sqrt(Math.Pow((fin.GetX() - origen.GetX()), 2) + Math.Pow((fin.GetY() - origen.GetY()), 2));
    }
    public double get_magnitud()
    {
        return magnitud;
    }


    public static Vector operator +(Vector sumando1, Vector sumando2)
    {
        Punto nuevo_origen = new Punto(sumando1.origen.GetX() + sumando2.origen.GetX(),
                                       sumando1.origen.GetY() + sumando2.origen.GetY());

        Punto nuevo_fin = new Punto(sumando1.fin.GetX() + sumando2.fin.GetX(),
                                    sumando1.fin.GetY() + sumando2.fin.GetY());


        return new Vector(nuevo_origen, nuevo_fin);
    }

    //Sobrecarga del operador de resta 
    public static Vector operator -(Vector restando1, Vector restando2)
    {
        Punto nuevo_origen = new Punto(restando1.origen.GetX() - restando2.origen.GetX(),
                                       restando1.origen.GetY() - restando2.origen.GetY());

        Punto nuevo_fin = new Punto(restando1.fin.GetX() - restando2.fin.GetX(),
                                    restando1.fin.GetY() - restando2.fin.GetY());

        return new Vector(nuevo_origen, nuevo_fin);
    }

    //Sobrecarga del operador de Multiplicación por un escalar
    public static Vector Multiply(Vector multiplicando, float scalar)
    {
        Punto nuevo_origen = new Punto(multiplicando.origen.GetX() * scalar,
                                        multiplicando.origen.GetY() * scalar);

        Punto nuevo_fin = new Punto(multiplicando.fin.GetX() * scalar,
                                    multiplicando.fin.GetY() * scalar);

        return new Vector(nuevo_origen, nuevo_fin);
   
    }

    //sobrecarga del operador de Multiplicación por un vector, multiplicación punto
    public static Vector operator *(Vector multiplicando1, Vector multiplicando2)
    {
        Punto nuevo_origen = new Punto(multiplicando1.origen.GetX() * multiplicando2.origen.GetX(),
                                        multiplicando1.origen.GetY() * multiplicando2.origen.GetY());

        Punto nuevo_fin = new Punto(multiplicando1.fin.GetX() * multiplicando2.fin.GetX(),
                                    multiplicando1.fin.GetY() * multiplicando2.fin.GetY());

        return new Vector(nuevo_origen, nuevo_fin);
    }
}

/*¿Por qué si los atributos "origen" y "fin" de los vectores son private, se pueden
acceder desde la sobrecarga del operador sin usar "getters"?

Se puede acceder ya que las sobrecargas en este caso están formando parte de la clase */