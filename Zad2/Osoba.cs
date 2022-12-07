using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    public abstract class Osoba
    {
        string imie, nazwisko;
        int pesel;
        public Osoba() {}
        public Osoba(string imie, string nazwisko, int pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.pesel= pesel;
        }
        public void SetFirstName(string imie)
        {
            this.imie = imie;
        }
        public void SetLastName(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }
        public void SetPesel(int pesel)
        {
            this.pesel = pesel;
        }
        public float GetAge(float pesel)
        {
            float date = (float)Math.Floor(pesel / 9);
            int age  = 22 - (int)date;
            return age;
        }
        public string GetGender(int pesel)
        {
            if (pesel % 2 == 0) return $"Kobieta";
            else return $"Meżczyzna";
        }
    }
}
