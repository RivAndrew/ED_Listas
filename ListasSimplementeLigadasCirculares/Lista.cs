using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadasCirculares
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
        }

        // Método que imprime todos los nodos.
        public string RecorrerLista()
        {
            if (ValidaVacio() == false)
            {
                string valores = string.Empty;
                nodoActual = nodoInicial;
                while (nodoActual.Siguiente != null && nodoActual.Siguiente != nodoInicial)
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
            while (nodoActual.Siguiente != null && nodoActual.Siguiente != nodoInicial) // mientras que el nodo siguiente exista y el nodo siguiente -
            {                                                                           // no sea igual al nodoInicial, se movera a ese nodo.
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nuevoNodo = new Nodo(valor);
            nodoActual.Siguiente = nuevoNodo;
            nuevoNodo.Siguiente = nodoInicial;  // conecta el nuevo nodo con el nodo inicial, haciendo la lista circular.
        }

        // Método que agrega un nodo al inicio de la lista.
        public void AgregarNodoInicio(string valor)
        {
            nodoActual = nodoInicial;
            Nodo nuevoNodo = new Nodo(valor, nodoActual.Siguiente);
            nodoActual.Siguiente = nuevoNodo;
        }

        // Método que busca un nodo dado un valor tipo string.
        public Nodo Buscar(string valor)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Siguiente != null && nodoBusqueda.Siguiente != nodoInicial) // mientras que el nodo siguiente exista y el nodo siguiente -
                {                                                                               // no sea igual al nodoInicial, se movera a ese nodo.
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
                while (nodoBusqueda.Siguiente != null && nodoBusqueda.Siguiente != nodoInicial) // mientras que el nodo siguiente exista y el nodo siguiente -
                {                                                                               // no sea igual al nodoInicial, se movera a ese nodo.
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

        // Método que busca el nodo anterior dado un valor tipo string.
        public Nodo BuscarAnterior(string valor)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Siguiente != null   // mientras que el nodo siguiente exista, su valor no sea el valor recibido y que el nodo siguiente -
                            && nodoBusqueda.Siguiente.Valor != valor && nodoBusqueda.Siguiente != nodoInicial)  // no sea igual al nodoInicial, se movera a ese nodo.
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    if (nodoBusqueda.Siguiente.Valor == valor)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }

        // Método que borra un nodo y reconecta los demas dado un valor tipo string.
        public void BorrarNodo(string valor)
        {
            if (ValidaVacio() == false)
            {
                nodoActual = Buscar(valor);
                if (nodoActual != null)
                {
                    Nodo nodoAnterior = BuscarAnterior(valor);
                    nodoAnterior.Siguiente = nodoActual.Siguiente;
                    nodoActual.Siguiente = null;
                }
            }
        }

        // Se imprimen todos los Nodos usando 'Siguiente' para comprobar la conexion de los Nodos,
        // saltandose el nodoInicial el cual se usa como referencia.
        public string ImprimirCiclo() 
        { 
            string datos = string.Empty;    // crea un string para guardar los valores.
            nodoActual = nodoInicial;   // se posiciona en el nodo inicial.
            for (int i = 0; i < 10; i++)    //  se ejecuta lo de adentro 9 veces.
            {
                if (nodoActual == nodoInicial)  // compara el nodo actual con el nodo inicial.
                {
                    nodoActual = nodoActual.Siguiente;  // si los nodos coinciden se salta ese nodo, ya que es el nodoInicial y solo lo usamos de referencia.
                }
                datos += nodoActual.Valor + "\n";   // guarda el valor del nodo actual con un salto de linea en datos.
                nodoActual = nodoActual.Siguiente;  // se mueve al siguiente nodo.
            }
            return datos;   // regresa una string con los valores guardados.
        }
    }
}
