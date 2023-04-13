using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatki.klasy
{
    public class ZwierzakDomowy
    {
        public string nazwa;
        public string gatunek;
        public DateTime data_urodzenia;

        public ZwierzakDomowy(string nazwa, string gatunek, DateTime data_urodzenia)
        {
            this.nazwa = nazwa;
            this.gatunek = gatunek;
            this.data_urodzenia = data_urodzenia;
        }

        public int obliczwiek()
        {
            DateTime dzisiaj = DateTime.Today;
            int wiek = dzisiaj.Year - data_urodzenia.Year;
            if (data_urodzenia > dzisiaj)
            {
                throw new Exception("Data urodzenia nie może być późniejsza niż dzisiaj.");
            }
            else if (wiek > 25)
            {
                throw new Exception("Zwierzak nie może mieć więcej niż 25 lat.");
            }
            return wiek;

        }
            public override string ToString()
        {
            try
            {
                int wiek = obliczwiek();
                return $"{nazwa}, gatunek: {gatunek}, urodzony {data_urodzenia.ToShortDateString()}, wiek: {wiek} lat.";
            }
            catch (Exception ex)
            {
                return $"{nazwa}, gatunek: {gatunek}, urodzony {data_urodzenia.ToShortDateString()}, błąd: {ex.Message}";
            }
        }
    }
}
