using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");
            //lista.AgregarNodo("Cuatro");

            lista.AgregarNodoInicio("Cero");
            Console.WriteLine("Se recorre la lista:\n" + lista.RecorrerLista());
            Console.WriteLine("Se recorre la lista inversa:\n" + lista.RecorrerListaInversa());

            Console.WriteLine("Buscando por indice '3':");
            Nodo NodoBusquedaIndice = lista.BuscarPorIndice(3);
            if (NodoBusquedaIndice != null)
            {
                Console.WriteLine(NodoBusquedaIndice.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.WriteLine("Buscando Uno:");
            Nodo NodoBusqueda = lista.Buscar("Uno");
            if (NodoBusqueda != null)
            {
                Console.WriteLine(NodoBusqueda.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.WriteLine("Buscando el anterior a Tres: ");
            Nodo NodoBusquedaAnterior = lista.Buscar("Tres");
            if (NodoBusquedaAnterior != null)
            {
                Console.WriteLine(NodoBusquedaAnterior.Anterior.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.WriteLine("\nEliminando el uno");
            lista.BorrarNodo("Uno");
            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Agregando nodo 'primero' al inicio ");
            lista.AgregarNodoInicio("primero");

            Console.WriteLine(lista.RecorrerLista());
            Console.WriteLine("Recorriendo la lista inversa\n" + lista.RecorrerListaInversa());

            //Console.WriteLine("");
            //Console.WriteLine("Eliminando el primero");
            //lista.BorrarNodo("primero");
            //Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Eliminando lista: ");
            lista.VaciarLista();
            Console.WriteLine(lista.RecorrerLista());
            Console.WriteLine(lista.RecorrerListaInversa());

            Console.ReadKey();
        }
    }
}
