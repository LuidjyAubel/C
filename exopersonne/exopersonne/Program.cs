using System;

namespace exopersonne
{
    class vivant
    {
        protected string nom;
        protected int DN;
        public void afficherC()
        {
            Console.WriteLine("Vivant : "+this.nom + " " + this.DN);
        }
        public int naissance()
        {  //methode objet personne 
            int n = 2021 - this.DN;
            return n;
        }
        public int getAge()             //geter
        {
            return 2021 - this.DN;
        }
    }

    class Chien : vivant
    {
        //private string nom;
        //private int DN;
        private int puce;
        public void afficherC()
        {
            Console.WriteLine(this.nom + " " + this.DN + " " + "(" + this.naissance() +")" +" " + this.puce);
        }
        public Chien(string nom, int puce, int DN)   //constructeur d'objet de type personne
        {
            this.nom = nom;
            this.puce = puce;
            this.DN = DN;
        }
       /* public int naissance()
        {  //methode objet personne 
            int n = 2021 - this.DN;
            return n;
        }*/
        public void setDN(int valeur)      //seter
        {
            if (valeur < 1910) return;
            if (valeur > 2021) return;
            this.DN = valeur;
        }
        public string getNom()
        {
            return this.nom;
        }

    }
    class Personne : vivant
    {
        //private int DN;
        //private string nom;
        private string prenom;  //champs de l'objet Personne
        Chien sonchien;
        public void adopter(Chien c)
        {
            this.sonchien = c; 
        }
        public void afficher()
        {
           
            Console.WriteLine(this.nom + " " + this.prenom + " " + this.DN + " (" + this.naissance()+ ")");
            if (this.sonchien == null)
            {
                Console.WriteLine("pas de chien");
            }
            else Console.WriteLine("chien " + this.sonchien.getNom());
            }
       /* public int naissance(){  //methode objet personne 
           int n = 2021 - this.DN;
            return n;
        }*/
        public Personne(string nom, string prenom, int age)   //constructeur d'objet de type personne
        {
            this.nom = nom;
            this.prenom = prenom;
            this.DN = age;
            this.sonchien = null;
        }
        public void setAge(int valeur)      //seter
        {
            if (valeur < 1910) return;
            if (valeur > 2021) return;
            this.DN = valeur;
        }
       /* public int getAge()             //geter
        {
            return 2021 - this.DN;
        }*/
        
    }

    class Program
    {
        static Personne p1, p2;
        static Chien c1,c2;
        static void Main(string[] args)
        {
            p1 = new Personne("Grimes","Rick", 1987);     //allocution direct grace aux constructeur
            p2 = new Personne("Dixon", "Daryl", 1959);
            c1 = new Chien("Dog", 10000, 2008);
            c2 = new Chien("Wouaf", 12000, 2010);
            c2.afficherC();
            c1.afficherC();
            p2.adopter(c1);
            //Console.WriteLine(p1.getAge());
            p1.setAge(1989);
            //p2.nom = "Grimes";
            //p2.prenom = "Rick";
            //p2.age = 40;
            //p1.nom = "Dixon";
            //p1.prenom = "Daryl";
            //p1.age = 45;
            p1.afficher();      // On affiche les données de l'objet P1 grace à la procedure dans l'objet personne
            p2.afficher();
            //Console.WriteLine(p2.naissance());
            //Console.WriteLine(p1.nom);

            Console.WriteLine("It's Good End !"); Console.ReadLine();
        }
    }
}
