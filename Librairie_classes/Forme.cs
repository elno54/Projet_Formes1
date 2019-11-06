using System;
using System.Collections.Generic;
using System.Text;

namespace Librairie_classes
{
    public abstract class Forme
    {
        protected int id;
        private Point laPosition;


        public int Id { get => id; set => id = value; }

        public Forme(int leId)
        {
            this.id = leId;
            
        }

        public abstract double calculerPerimetre();
        public abstract double calculerSurface();
    }
}
