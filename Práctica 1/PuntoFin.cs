using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//realización de metodo setter del punto fin recibiendo un punto y recibiendo 2 coordenadas
class VectorP
{
    Punto fin;

    public VectorP()
    {
        fin = new Punto(1, 1);

    }
   public void set_fin(Punto _fin)
    {
        fin = new Punto(_fin.GetX(), _fin.GetY());
    }
    public void set_fin(float x,float y)
    {
        fin = new Punto(x, y);
    }
}