using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
{
    internal class Lista
    {
        Nodo nodoInicial;
        Nodo nodoActual;

        // Constructor
        public Lista()
        {
            nodoInicial = new Nodo();
            nodoInicial.Siguiente = nodoInicial;
        }

        // Método que verifica si la lista esta vacia o no, usando un booleano.
        public bool ValidaVacio()
        {
            if (nodoInicial.Siguiente == nodoInicial)
            {
                return true;
            }
            return false;
        }

        // Método que desconecta el nodo inicio de los demas nodos. 
        public void VaciarLista()
        {
            nodoInicial.Siguiente = nodoInicial;
            nodoInicial.Anterior = nodoInicial;
        }

        // Método que imprime todos los nodos.
        public string RecorrerLista()
        {
            if (ValidaVacio() == false)
            {
                string valores = string.Empty;
                nodoActual = nodoInicial;
                while (nodoActual.Siguiente != nodoInicial) // mientras que el nodo siguiente sea diferente del nodoInicial.
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
            while (nodoActual.Siguiente != nodoInicial)
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nuevoNodo = new Nodo(valor, nodoActual, nodoInicial);  // conecta el nodo nuevo con el nodo actual.
            nodoActual.Siguiente = nuevoNodo;
            nodoInicial.Anterior = nuevoNodo;
        }

        // Método que agrega un nodo al inicio de la lista.
        public void AgregarNodoInicio(string valor)
        {
            Nodo nuevoNodo = new Nodo(valor, nodoInicial, nodoInicial.Siguiente);
            nodoInicial.Siguiente.Anterior = nuevoNodo;
            nodoInicial.Siguiente = nuevoNodo;
        }

        // Método que agrega un nodo al inicio de la lista.
        public Nodo Buscar(string valor)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Siguiente != nodoInicial)   // mientras que el nodo siguiente sea diferente del nodoInicial.
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
                while (nodoBusqueda.Siguiente != nodoInicial)   // mientras que el nodo siguiente sea diferente del nodoInicial.
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
                    nodoActual.Anterior.Siguiente = nodoActual.Siguiente;
                    nodoActual.Siguiente.Anterior = nodoActual.Anterior;
                    nodoActual.Siguiente = null;
                    nodoActual.Anterior = null;
                }
            }
        }

        // Método que imprime los nodos de forma inversa.
        public string RecorrerListaInversa()
        {
            string valores = string.Empty;
            nodoActual = nodoInicial;
            while (nodoActual.Anterior != nodoInicial)  // mientras que el nodo siguiente sea diferente del nodoInicial.
            {
                nodoActual = nodoActual.Anterior;
                valores += $"{nodoActual.Valor}\n";
            }
            return valores;
        }

        // Se imprimen todos los Nodos usando 'Siguiente' para comprobar la conexion de los Nodos,
        // saltandose el nodoInicial el cual se usa como referencia.
        public string ImprimirCiclo()
        {
            string datos = string.Empty;    // crea un string para guardar los valores.
            nodoActual = nodoInicial;   // se posiciona en el nodo inicial.
            for (int i = 0; i < 10; i++)    // se ejecuta las instrucciones de adentro 10 veces.
            {
                if (nodoActual == nodoInicial)  // compara si el nodo actual es el nodo inicial.
                {
                    nodoActual = nodoActual.Siguiente;  // se salta el nodoInicial ya que solo se usa como referencia.
                }
                datos += nodoActual.Valor + "\n";   // guarda el valor del nodo actual con un salto de linea en datos.
                nodoActual = nodoActual.Siguiente;  // se mueve al nodo siguiente.
            }
            return datos;   // regresa una string con los valores guardados.
        }

        // Se imprimen todos los Nodos usando 'Anterior' para comprobar la conexion de los Nodos,
        // saltandose el nodoInicial el cual se usa como referencia.
        public string ImprimirCicloInverso()
        {
            string datos = string.Empty;
            nodoActual = nodoInicial;
            for (int i = 0; i < 10; i++)
            {
                if (nodoActual == nodoInicial)
                {
                    nodoActual = nodoActual.Anterior;   // se salta el nodoInicial ya que solo se usa como referencia.
                }
                datos += nodoActual.Valor + "\n";   // guarda el valor del nodo actual con un salto de linea en datos.
                nodoActual = nodoActual.Anterior;   // se mueve al nodo anterior.
            }
            return datos;   // regresa una string con los valores guardados.
        }
    }
}
