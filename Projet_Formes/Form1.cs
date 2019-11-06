using Librairie_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projet_Formes
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics formGraphics;
        private List<Forme> lesFormes;
        public Form1()
        {
            InitializeComponent();
            this.lesFormes = new List<Forme>();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Carre c1 = new Carre(Convert.ToInt32(textBox1.Text), lesFormes.Count()+1);
            lesFormes.Add(c1);
            listBox1.Items.Add("Carré " + c1.Cote);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Cercle c1 = new Cercle(Convert.ToInt32(textBox2.Text), lesFormes.Count() + 1);
            lesFormes.Add(c1);
            listBox1.Items.Add("Cercle " + c1.Rayon);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Librairie_classes.Rectangle r1 = new Librairie_classes.Rectangle(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), lesFormes.Count() + 1);
            lesFormes.Add(r1);
            listBox1.Items.Add("Rectangle " + r1.Longueur + "en longueur, " + r1.Largeur + "en largeur");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics = this.panel1.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new System.Drawing.Rectangle(50, 50, 200, 150));
            myBrush.Dispose();


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            System.Drawing.Graphics formGraphics = this.panel1.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new System.Drawing.Rectangle(50, 50, 200, 200));
            myBrush.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            System.Drawing.Graphics formGraphics = this.panel1.CreateGraphics();
            Pen myPen = new Pen(Color.Green);
            formGraphics.DrawEllipse(myPen, 50, 100, Convert.ToInt32(textBox2.Text), 30);
            myBrush.Dispose();
        }
    }
}
