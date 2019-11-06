using System;
using System.Collections.Generic;
using System.Text;

namespace Librairie_classes
{
    public class Cercle : Forme
    {
        private double rayon;

        public Cercle(double lerayon, int id) : base(id)
        {
            this.rayon = lerayon;
        }

        public double Rayon { get => rayon; set => rayon = value; }

        public override double calculerPerimetre()
        {
            double perimetre;
            perimetre = 2 * 3.14 * rayon;
            return perimetre;
        }

        public override double calculerSurface()
        {
            double surface;
            surface = 3.14 * rayon * rayon;
            return surface;
        }
    }
}
