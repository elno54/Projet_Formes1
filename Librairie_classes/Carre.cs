using System;
using System.Collections.Generic;
using System.Text;

namespace Librairie_classes
{
    public class Carre : Forme
    {
        private int cote;

        public Carre(int lacote, int id): base(id)
        {
            this.cote = lacote;
        }

        public int Cote { get => cote; set => cote = value; }

        public override double calculerSurface()
        {
            int surface;
            surface = cote * cote;
            return surface;
        }

        public override double calculerPerimetre()
        {
            int perimetre;
            perimetre = cote * 4;
            return perimetre;
        }
    }
}
