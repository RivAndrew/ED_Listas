using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;

        // Constructor
        public Lista()
        {
            nodoInicial = new Nodo();
        }

        // Método que verifica si la lista esta vacia o no, usando un booleano.
        public bool ValidaVacio()
        {
            if (nodoInicial.Siguiente == null)
            {
                return true;
            }
            return false;
        }

        // Método que desconecta el nodo inicio de los demas nodos. 
        public void VaciarLista()
        {
            nodoInicial.Siguiente = null;
            nodoInicial.Anterior = null;    // desconecta el nodoInicial con el anterior.
        }

        // Método que imprime todos los nodos.
        public string RecorrerLista()
        {
            if (ValidaVacio() == false)
            {
                string valores = string.Empty;
                nodoActual = nodoInicial;
                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                    valores += $"{nodoActual.Valor}\n";
                }
                return valores;
            }
            return "La lista esta vacia";
        }

        // Método que agrega un nodo al final de la lista.
        public void AgregarNodo(string valor)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nuevoNodo = new Nodo(valor);
            nodoActual.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = nodoActual;    //conecta el nodo nuevo con el nodo actual.
        }

        // Método que agrega un nodo al inicio de la lista.
        public void AgregarNodoInicio(string valor)
        {
            nodoActual = nodoInicial;
            Nodo nuevoNodo = new Nodo(valor, nodoInicial, nodoActual.Siguiente);
            nodoActual.Siguiente.Anterior = nuevoNodo;  // se conecta el nodo siguiente con el nuevo nodo.
            nodoActual.Siguiente = nuevoNodo;
        }

        // Método que agrega un nodo al inicio de la lista.
        public Nodo Buscar(string valor)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Siguiente != null)
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    if (nodoBusqueda.Valor == valor)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }

        // Método que busca un nodo dado un indice con valor tipo int.
        public Nodo BuscarPorIndice(int indice)
        {
            int Indice = -1;
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Siguiente != null)
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    Indice++;
                    if (Indice == indice)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }

        // Como es una lista doblemente ligada, usar 'Anterior' es lo mismo que usar el metodo BuscarAnterior.

        // Método que borra un nodo y reconecta los demas dado un valor tipo string.
        public void BorrarNodo(string valor)
        {
            if (ValidaVacio() == false)
            {
                nodoActual = Buscar(valor);
                if (nodoActual != null)
                {
                    nodoActual.Anterior.Siguiente = nodoActual.Siguiente;   // se conecta el nodo anterior con el nodo siguiente.
                    nodoActual.Siguiente.Anterior = nodoActual.Anterior;    // se conecta el nodo siguiente con el nodo anterior
                    nodoActual.Siguiente = null;    // se desconectan de ambos sentidos.
                    nodoActual.Anterior = null;
                }
            }
        }

        // Método que imprime los nodos de forma inversa.
        public string RecorrerListaInversa()
        {
            string valores = string.Empty;  // crea un string para guardar los valores.
            while (nodoActual.Siguiente != null)    // mientras que el siguiente exista, se mueve a ese nodo.
            {
                nodoActual = nodoActual.Siguiente;
            }
            while (nodoActual.Anterior != null) // mientras que el nodo anterior exista.
            {
                valores += $"{nodoActual.Valor}\n"; // guarda el valor del nodo actual en un string y se mueve al nodo anterior.
                nodoActual = nodoActual.Anterior;
            }
            return valores; // regresa una string con los valores guardados.
        }
    }
}
