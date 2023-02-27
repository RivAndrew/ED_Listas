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

            //lista.AgregarNodoInicio("Cero");
            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");
            lista.AgregarNodo("Cuatro");

            lista.AgregarNodoInicio("Cero");
            Console.WriteLine(lista.RecorrerLista());
            Console.WriteLine(lista.RecorrerListaInversa());

            Console.WriteLine("Buscando por indice '4':");
            Nodo NodoBusquedaIndice = lista.BuscarPorIndice(4);
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

            Console.WriteLine("Buscando el anterior a Cuatro: ");
            Nodo NodoBusquedaAnterior = lista.BuscarAnterior("Cuatro");
            if (NodoBusquedaAnterior != null)
            {
                Console.WriteLine(NodoBusquedaAnterior.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.WriteLine("");
            Console.WriteLine("Eliminando el uno");
            lista.BorrarNodo("Uno");
            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Agregando nodo 'Cinco'");
            lista.AgregarNodo("Cinco");
            //Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Recorriendo la lista inversa\n" + lista.RecorrerListaInversa());

            Console.ReadKey();
        }
    }
}
