using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VegaJuego
{
    internal class Link : Personaje
    {
        private int salud;
        private int escudo;
        private int arma;

        public Link(Level1 vegaZelda, int x, int y, int s, int e, int a) : base(vegaZelda, x, y)
        {

            public int Arma
                {
            get{ return arma; }
            set {arma=value;}
            }



        }
    }

}
