using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.AgregarNodo("Uno");
            lista.AgregarNodo("Dos");
            lista.AgregarNodo("Tres");
            lista.AgregarNodo("Cuatro");

            lista.AgregarNodoInicio("Cero");
            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("Se imprime el primero, el ultimo y el ultimo.siguiente: ");
            Console.WriteLine(lista.imprimirPrimerUltimo());
            
            Console.WriteLine("Busca el indice 2:");
            Nodo NodoBusquedaIndice = lista.BuscarPorIndice(2);
            if (NodoBusquedaIndice != null)
            {
                Console.WriteLine(NodoBusquedaIndice.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.WriteLine("Busca el Uno");
            Nodo NodoBusqueda = lista.Buscar("Uno");
            if (NodoBusqueda != null)
            {
                Console.WriteLine(NodoBusqueda.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.WriteLine("Busca el anterior al Dos");
            Nodo NodoBusquedaAnterior = lista.BuscarAnterior("Dos");
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

            lista.AgregarNodo("Cinco");

            Console.WriteLine("Se imprime el primero, el ultmo y el ultimo.siguiente:");
            Console.WriteLine(lista.imprimirPrimerUltimo());

            Console.WriteLine("\nSe imprime ciclo de 10\n" + lista.ImprimirCiclo());

            Console.ReadKey();
        }
    }
}
