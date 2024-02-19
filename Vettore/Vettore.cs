using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettore
{
    internal class Vettore
    {
        public Vettore(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        public static Vettore Parse(string s)
        {
            string[] xy = s.Split(';');
            return new Vettore(double.Parse(xy[0]), double.Parse(xy[1]));
        }
        public override string ToString()
        {
            return $"{X};{Y}";
        }

        public static bool TryParse(string s, out Vettore v)
        {
            try
            {
                v = Vettore.Parse(s);
                return true;
            }
            catch
            {
                v = null;
                return false;
            }
        }

        public static Vettore operator * (Vettore a, Vettore b)
        {
            return new Vettore(a.X * b.X, a.Y * b.Y);
        }

        public static Vettore operator + (Vettore a, Vettore b)
        {
            return new Vettore(a.X + b.X, a.Y + b.Y);
        }

        public static Vettore operator - (Vettore a, Vettore b)
        {
            return new Vettore(a.X - b.X, a.Y - b.Y);
        }

        public static Vettore operator - (Vettore a)
        {
            return new Vettore(-a.X, -a.Y);
        }

        public static Vettore operator * (Vettore a, int b)
        {
            return new Vettore (a.X*b, a.Y * b);
        }

        public static Vettore operator * (int b, Vettore a)
        {
            return new Vettore(b*a.X, b*a.Y);
        }

        public static Vettore operator / (Vettore a, int b)
        {
            return new Vettore(a.X/b, a.Y/b);
        }
        public static Vettore operator + (Vettore a)
        {
            return new Vettore(+a.X,+a.Y);
        }

        public double Modulo(Vettore v)
        {
            double risultato = Math.Sqrt(Math.Pow(v.X, 2) + Math.Pow(v.Y, 2));

            return risultato;
        }

        public static bool operator != (Vettore a, Vettore b)
        {
            if (!(a.X == b.X && a.Y == b.Y))
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator == (Vettore v1, Vettore v2)
        {
            if (v1.X == v2.X && v1.Y == v2.Y)
            {
                return true;
            }
            else
                return false;
        }

    }



}
