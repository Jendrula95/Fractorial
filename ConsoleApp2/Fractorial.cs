using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
        class Fractorial : IEquatable, IComparable<Fractorial>

        {
        // Uzywam Getterów i Setterów do wyświetlania tylko licznika i mianownika
            protected int num { get; set; }
            protected int nom { get; set; }

            // tworze konstruktor domyślny

        public Fractorial()
            {
            
               
        }
    
        // tworze konstruktor kopiujacy
            public Fractorial(Fractorial previousFractorial)
            {
                num = previousFractorial.num;
                nom = previousFractorial.nom;
            }
       
           // tworze konstruktor z dwoma argumentami
            public Fractorial(int numerator, int nominative)
            {
            if (nominative == 0)
            {
                throw new ArgumentException("nominative cannot be zero.", nameof(nominative));
            }
            num = numerator;
            nom = nominative;
            }
        // tworze przeciążam operatorów +,-,/,*
            public static Fractorial operator +(Fractorial a) => a;
            public static Fractorial operator -(Fractorial a) => new Fractorial(-a.num, a.nom);

            public static Fractorial operator +(Fractorial a, Fractorial b)
                => new Fractorial(a.num * b.nom + b.num * a.nom, a.nom * b.nom);

            public static Fractorial operator -(Fractorial a, Fractorial b)
                => a + (-b);

            public static Fractorial operator *(Fractorial a, Fractorial b)
                => new Fractorial(a.num * b.num, a.nom * b.nom);
            public static Fractorial operator /(Fractorial a, Fractorial b)
            {
                if (b.num == 0)
                {
                    throw new DivideByZeroException();
                }
                return new Fractorial(a.num * b.nom, a.nom * b.num);
            }

            public override string ToString() => $"{num} / {nom}";

            public string ToString(string fr)
            {
                return this.ToString();
            }
        // tworze metode CompareTo do sprawdzenia poprawności IComparable poprzez pobranie dwóch ułamków i porównanie ich ze sobą
        public int CompareTo(Fractorial other)
        {
            if(other ==null) return 1;
            int check = (this.num * other.nom) - (other.num * this.nom );
            if (check > 0) return 1;
            else if (check == 0) return 0;
            else return -1;
        }
        /* tworze metode RoundUp która jawnie zaokrągla ułamek w góre dzieląc licznik przez mianownik nastepnie odejmując od niego modulo z dzielenia licznika przez mianownik i 
         sprawdzając czy jest większy od zera jeśli tak to do wyniku z modulo dodajemy 1 i w ten sposób zaokrąglamy w góre jeśli nie to wyświetla wynik z modulo*/
        public int RoundUp()
        {
            double result = (double)this.num / (double)this.nom;
            int result2 = this.num % this.nom;
            if (result - (int)(result2) > 0)
            {
                return result2 + 1;
            }
            return result2;
        }
        // tworze metode RoundDown która zaokrągla w dół poprzez modulo z licznika i mianownika
        public int RoundDown()
        {
            return this.num % this.nom;
        }
    }
    }


