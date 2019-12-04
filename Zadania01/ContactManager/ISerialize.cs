using System.Collections.Generic;

namespace ContactManager
{
    public interface ISerialize
    {
        void zapisz(List<Osoba> kontakty);
        void wczytaj(Kontakty kontakty);
    }
}