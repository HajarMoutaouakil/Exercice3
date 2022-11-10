using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    public class Point
    {
        private double Abscisse;            
        private double Ordonne;
        //constructeur par defaut
        public Point()    
        {
        }
        //Le constructeur d'initialisation
        public Point(double x, double y)   
        {
            Abscisse = x;
            Ordonne = y;
        }
        //Le getter de l'attribut Abscisse___________________________
        public double getAbscisse()         
        {
            return Abscisse;
        }
        //Le setter de l'attribut Abscisse____________________________
        public void setAbscisse(double a)   
        {
            Abscisse = a;
        }
        //Le getter de l'attribut Ordonne_______________
        public double getOrdonne()          
        {
            return Ordonne;
        }
        //Le setter de l'attribut Ordonne___________________
        public void setOrdonne(double o)    
        {
            Ordonne = o;
        }
        // une fonction qui retourne la racine d'un nombre donnée
        static public double Sqr(double a)  
        {
            return a * a;
        }
        //Distance____________________________________
        static public double Distance(Point Point1, Point Point2)  
        {
            return Math.Sqrt(Sqr(Point2.Ordonne - Point1.Ordonne) + Sqr(Point2.Abscisse - Point1.Abscisse));
        }
        //Egalité_____________________________
        static public void Egalité(Point P1, Point P2)
        {
            if ((P1.Abscisse == P2.Abscisse) && (P1.Ordonne == P2.Ordonne))
            {
                Console.WriteLine("les 2 points sont egaux");
            }
            else
                Console.WriteLine("les 2 points ne sont pas egaux");
        }
        //Translation_____________________________________________
        static public void Translation(Point P1)
        {
            Console.WriteLine("nouveau abssice :");
            P1.Abscisse = int.Parse(Console.ReadLine());
            Console.WriteLine("nouveau ordonnee :");
            P1.Ordonne = int.Parse(Console.ReadLine());
            Console.WriteLine("les nouveaux coordonnees du point sont : Abc = " + P1.Abscisse + " Ord = " + P1.Ordonne);
        }
        //Linéarité__________________________________
        static public void Linéarité(Point P1, Point P2, Point P3)
        {
            double a, b;
            if (P1.Abscisse != P2.Abscisse) 
            {
                a = (P1.Ordonne - P2.Ordonne) / (P1.Abscisse - P2.Abscisse);
                b = P1.Ordonne + a * P1.Abscisse;   
                if (a * P3.Abscisse + b == P3.Ordonne)
                {
                    Console.WriteLine("les 3 points sont lineaire");
                }
                else
                    Console.WriteLine("les 3 points ne sont pas lineaire");
            }

        }
        static void Main(string[] args)
        {
            Point P1 = new Point();
            Point P2 = new Point();
            Point P3 = new Point();


            Console.Write("Entrez l'abscisse de P1");
            P1.Abscisse = int.Parse(Console.ReadLine());
            Console.Write("Entrez l'ordonnee de P1");
            P1.Ordonne = int.Parse(Console.ReadLine());
            Console.Write("Entrez l'abscisse de P2");
            P2.Abscisse = int.Parse(Console.ReadLine());
            Console.Write("Entrez l'ordonnee de P2");
            P2.Ordonne = int.Parse(Console.ReadLine());

            //Distance______________________________________________________________
            //Console.WriteLine("la distance entre P1 ET P2 est :" + Distance(P1, P2));
            //Egalité_________________________________________________________________
            //Egalité(P1, P2);
            //Translation_____________________________________________________________
            //Translation(P1);
            //Linéarité________________________________________________________________
            //Console.Write("Entrez l'abscisse de P3");
            //P3.Abscisse = int.Parse(Console.ReadLine());
            // Console.Write("Entrez l'ordonnee de P3");
            // P3.Ordonne = int.Parse(Console.ReadLine());
            // Linéarité(P1, P2, P3);
        }

    }

}