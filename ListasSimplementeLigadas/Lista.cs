using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadas
{
    internal class Lista
    {
        // Se crean objetos tipo Nodo, uno para usarse como referencia: nodoInicial
        // y el otro para modificarse al criterio del autor.
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
                string valores = string.Empty;  // crea un string para guardar los valores.
                nodoActual = nodoInicial;   // se posiciona en el inicio de la lista.
                while (nodoActual.Siguiente != null)    // mientras que el nodo siguiente exista, se movera a ese nodo y obtener su valor.
                {
                    nodoActual = nodoActual.Siguiente;
                    valores += $"{nodoActual.Valor}\n";
                }
                return valores; // regresa una string con los valores guardados.
            }
            return "La lista esta vacia.";
        }

        // Método que agrega un nodo al final de la lista.
        public void AgregarNodo(string valor)
        {
            nodoActual = nodoInicial;   // se posiciona en el inicio de la lista.
            while (nodoActual.Siguiente != null)    // mientras que el nodo siguiente exista, se movera a ese nodo.
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nuevoNodo = new Nodo(valor); // crea un nuevo nodo y conecta el nodo actual con el nuevo.
            nodoActual.Siguiente = nuevoNodo;
        }

        // Método que agrega un nodo al inicio de la lista.
        public void AgregarNodoInicio(string valor)
        {
            nodoActual = nodoInicial;   // se posiciona en el inicio de la lista.
            Nodo nuevoNodo = new Nodo(valor, nodoActual.Siguiente); // crea un nuevo nodo y lo conecta con el nodo siguiente.
            nodoActual.Siguiente = nuevoNodo;   // conecta el nodo actual, el cual es el inicio, con el nuevo nodo.
        }

        // Método que busca un nodo dado un valor tipo string.
        public Nodo Buscar(string valor)
        {
            if (ValidaVacio() == false) // verifica si la lista esta vacia.
            {
                Nodo nodoBusqueda = nodoInicial;    // crea un nuevo nodo y lo posiciona al inicio de la lista.
                while (nodoBusqueda.Siguiente != null)  // mientras que el nodo siguiente exista, se movera a ese nodo.
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    if (nodoBusqueda.Valor == valor)    // compara si el valor del nodo en el que estamos es igual al valor recibido.
                    {
                        return nodoBusqueda;    // si el valor es igual significa que encontro el nodo y lo regresa.
                    }
                }
            }
            return null;    // si la lista esta vacia o no encontro el nodo regresara null.
        }

        // Método que busca un nodo dado un indice con valor tipo int.
        public Nodo BuscarPorIndice(int indice)
        {
            int Indice = -1;    // crea un indice propio del metodo para comparar con el indice recibido.
            if (ValidaVacio() == false) // verifica si la lista esta vacia.
            {
                Nodo nodoBusqueda = nodoInicial;    // crea un nuevo nodo y lo posiciona al inicio de la lista.
                while (nodoBusqueda.Siguiente != null)  // mientras que el nodo siguiente exista, se movera a ese nodo.
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    Indice++;   // ya que se recorre incrementa el indice en 1.
                    if (Indice == indice)   // compara el indice propio con el indice recibido.
                    {
                        return nodoBusqueda;    // si los indicen coinciden entonces estamos en el nodo correcto y lo regresamos.
                    }
                }
            }
            return null;    // si la lista esta vacia o no encontro el nodo regresara null.
        }

        // Método que busca el nodo anterior dado un valor tipo string.
        public Nodo BuscarAnterior(string valor)
        {
            if (ValidaVacio() == false) // verifica si la lista esta vacia.
            {
                Nodo nodoBusqueda = nodoInicial;    // crea un nuevo nodo y lo posiciona al inicio de la lista.
                while (nodoBusqueda.Siguiente != null   // mientras que el nodo siguiente exista y su valor no sea igual al valor recibido, se movera a ese nodo.
                            && nodoBusqueda.Siguiente.Valor != valor)   
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    if (nodoBusqueda.Siguiente.Valor == valor)  // compara si el valor del nodo siguiente es igual al valor recibido.
                    {
                        return nodoBusqueda;    // si los valores coinciden entonces el nodo en el que estamos es el nodo anterior y lo regresamos.
                    }
                }
            }
            return null;    // si la lista esta vacia o no encontro el nodo regresara null.
        }

        // Método que borra un nodo y reconecta los demas dado un valor tipo string.
        public void BorrarNodo(string valor)
        {
            if (ValidaVacio() == false) // verifica si la lista esta vacia.
            {
                nodoActual = Buscar(valor); // busca el valor a borrar y lo introduce en nodoActual para modificarse.
                if (nodoActual != null) // si el nodo encontrado existe, significa que encontro el nodo.
                {
                    Nodo nodoAnterior = BuscarAnterior(valor);  // crea un nuevo nodo el cual es el anterior al nodo actual.
                    nodoAnterior.Siguiente = nodoActual.Siguiente;  // crea una conexion del nuevo nodo con el nodo siguiente, asi conectandolos.
                    nodoActual.Siguiente = null;    // desconecta el nodo actual, dando la idea de que se borro.
                }
            }
        }
    }
}
