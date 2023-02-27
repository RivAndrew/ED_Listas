using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
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
            //lista.AgregarNodo("Cuatro");

            lista.AgregarNodoInicio("Cero");
            Console.WriteLine(lista.RecorrerLista());
            Console.WriteLine(lista.RecorrerListaInversa());

            Console.WriteLine("Se imprime el primero, el ultimo y el nodoInicio: ");
            Console.WriteLine(lista.imprimirPrimerUltimoSiguiente());
            Console.WriteLine("Se imprime el ultimo, el nodoInicio y el primero: ");
            Console.WriteLine(lista.imprimirUltimoPrimerAnterior());

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
            Nodo NodoBusquedaAnterior = lista.BuscarAnterior("Tres");
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

            Console.WriteLine("Agregando nodo al inicio 'primero'");
            lista.AgregarNodoInicio("primero");

            Console.WriteLine("Se imprime el primero, el ultimo y el nodoInicio: ");
            Console.WriteLine(lista.imprimirPrimerUltimoSiguiente());
            Console.WriteLine("Se imprime el ultimo, el nodoInicio y el primero: ");
            Console.WriteLine(lista.imprimirUltimoPrimerAnterior());

            Console.WriteLine("Recorriendo la lista inversa\n" + lista.RecorrerListaInversa());
            Console.WriteLine(lista.RecorrerLista());
            Console.WriteLine("\nSe imprime ciclo de 10\n" + lista.ImprimirCiclo());
            Console.WriteLine("");
            Console.WriteLine("Eliminando el primero");
            lista.BorrarNodo("primero");
            Console.WriteLine(lista.RecorrerLista());

            Console.WriteLine("\nSe imprime ciclo de 10\n" + lista.ImprimirCiclo());
            Console.WriteLine("\nSe imprime ciclo inverso de 10\n" + lista.ImprimirCicloInverso());

            Console.ReadKey();
        }
    }
}
