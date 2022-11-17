using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Bernabini
{
    internal class Libro
    {
        internal string autore { get; set; }
        internal string titolo { get; set; }
        internal string annoDiPublicazione { get; set; }
        internal string editore { get; set; }
        internal int numeroDiPagine { get; set; }

        internal Libro(string autore, string titolo, string annoDiPublicazione, string editore, int numeroDiPagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.annoDiPublicazione = annoDiPublicazione;
            this.editore = editore;
            this.numeroDiPagine = numeroDiPagine;
        }
        internal string toString(Libro libro)
        {
            return libro.titolo + "autore: " +  autore + "anno di publicazione: " + annoDiPublicazione + "editore: " + editore + "numero di pagine: " + numeroDiPagine;
        }
        internal string readingTime(Libro libro)
        {
            string tempoDiLettura;
            if (libro.numeroDiPagine < 100)
            {
                tempoDiLettura = "tempo di lettura: meno di 1 ora";
            } else if(libro.numeroDiPagine > 100)
            {
                tempoDiLettura = "tempo di lettura: più di 2 ore";
            }
            else
            {
                tempoDiLettura = "tempo di lettura: circa 2 ore";
            }
            return tempoDiLettura;
        }
    }
}
