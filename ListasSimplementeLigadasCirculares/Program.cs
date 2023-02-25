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

            //Console.WriteLine(lista.RecorrerLista());

            lista.Agregar("Uno");
            lista.Agregar("Dos");
            lista.Agregar("Tres");
            lista.Agregar("Cuatro");
            //Console.WriteLine(lista.RecorrerLista());


            lista.AgregarNodoInicio("Cero");
            Console.WriteLine(lista.Recorrer());

            Console.WriteLine(lista.imprimirPrimerUltimo());

            Nodo NodoBusquedaIndice = lista.BuscarPorIndice(2);
            if (NodoBusquedaIndice != null)
            {
                Console.WriteLine(NodoBusquedaIndice.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }
            Console.WriteLine("\nPrueba");
            Console.WriteLine(lista.imprimirPrimerUltimo());

            Console.WriteLine("\nPrueba de Dos");
            Console.WriteLine(lista.NodoAnterior());

            Console.WriteLine("\nPrueba de Dos");
            Console.WriteLine(lista.NodoPosterior());


            Nodo NodoBusqueda = lista.Buscar("Uno");
            if (NodoBusqueda != null)
            {
                Console.WriteLine(NodoBusqueda.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }

            Console.WriteLine("\nPrueba");
            Console.WriteLine(lista.imprimirPrimerUltimo());

            Nodo NodoBusquedaAnterior = lista.BuscarAnterior("Dos");
            if (NodoBusquedaAnterior != null)
            {
                Console.WriteLine(NodoBusquedaAnterior.Valor);
            }
            else
            {
                Console.WriteLine("No encontrado!");
            }
            Console.WriteLine("\nPrueba");
            Console.WriteLine(lista.imprimirPrimerUltimo());

            Console.WriteLine("");
            Console.WriteLine(lista.Recorrer());
            Console.WriteLine("Eliminando el uno");
            lista.BorrarNodo("Uno");
            Console.WriteLine(lista.Recorrer());

            Console.WriteLine(lista.imprimirPrimerUltimo());

            Console.ReadKey();
        }
    }
}
