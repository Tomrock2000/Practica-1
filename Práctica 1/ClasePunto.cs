using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Punto
    {
        private float coordx;
        private float coordy;

  
    public Punto(float x, float y)
        {
            coordx = x;
            coordy = y;
        }
    public float SetX(float x) => coordx = x;
    public float GetX()
        {
            return coordx;
        }
    public float SetY(float y) => coordy = y;
    public  float GetY()
        {
            return coordy;
        }
    }
