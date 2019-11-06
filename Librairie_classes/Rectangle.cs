using System;
using System.Collections.Generic;
using System.Text;

namespace Librairie_classes
{
   public class Rectangle : Forme
    {
        private int longueur;
        private int largeur;

        public Rectangle(int lalongueur, int lalargeur, int id): base(id)
        {
            this.longueur = lalongueur;
            this.largeur = lalargeur;

        }

        public int Longueur { get => longueur; set => longueur = value; }
        public int Largeur { get => largeur; set => largeur = value; }

       

        public override double calculerSurface()
        {
            int surface;
            surface = longueur * largeur;
            return surface;
        }

        public override double calculerPerimetre()
        {
            int perimetre;
            perimetre = (longueur * 2) + (largeur * 2);
            return perimetre;

        }
    }
}
