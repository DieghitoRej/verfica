using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Bernabini
{
    internal class Biblioteca
    {
        internal string Nome { get; set; }
        internal string Indirizzo { get; set; }

        internal double OrarioApertura { get; set; }
        internal double OrarioChiusura { get; set; }
        internal List<Libro> ListaLibri { get; set; }

        internal void AggiungiLibro(string autore, string nome, string annoDiPublicazione, string editore, int numeroDiPagine)
        {
            Libro libroDaAggiungere = new Libro(autore, nome, annoDiPublicazione, editore, numeroDiPagine);
            ListaLibri.Add(libroDaAggiungere);
        }
        internal void RicercaLibro()
        {

        }
        internal void RicercaAutore()
        {

        }
        internal int ContaLibri()
        {
            return ListaLibri.Count;
        }


    }
}
