using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Nodo
    {
        public string Valor { get; set; }
        public Nodo Anterior { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string valor = "Inicio", Nodo anterior = null, Nodo siguente = null)
        {
            Valor = valor;
            Anterior = anterior;
            Siguiente = siguente;
        }
    }
}
