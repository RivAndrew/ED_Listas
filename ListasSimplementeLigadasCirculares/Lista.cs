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
        public Lista()
        {
            nodoInicial = new Nodo();
        }
        public bool ValidaVacio()
        {
            if (nodoInicial.Siguiente == null)
            {
                return true;
            }
            return false;
        }
        public void VaciarLista()
        {
            nodoInicial.Siguiente = null;
        }
        public string RecorrerLista()
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
        public void AgregarNodo(string valor)
        {
            nodoActual = nodoInicial;
            while (nodoActual.Siguiente != null && nodoActual.Siguiente != nodoInicial)
            {
                nodoActual = nodoActual.Siguiente;
            }
            Nodo nuevoNodo = new Nodo(valor);
            nodoActual.Siguiente = nuevoNodo;
            nuevoNodo.Siguiente = nodoInicial;
        }
        public void AgregarNodoInicio(string valor)
        {
            nodoActual = nodoInicial;
            Nodo nuevoNodo = new Nodo(valor, nodoActual.Siguiente);
            nodoActual.Siguiente = nuevoNodo;
        }
        public Nodo Buscar(string valor)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Siguiente != null && nodoBusqueda.Siguiente != nodoInicial)
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
        public Nodo BuscarPorIndice(int indice)
        {
            int Indice = -1;
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Siguiente != null && nodoBusqueda.Siguiente != nodoInicial)
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
        public Nodo BuscarAnterior(string valor)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Siguiente != null
                            && nodoBusqueda.Siguiente.Valor != valor && nodoBusqueda.Siguiente != nodoInicial)
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
            string datos = string.Empty;
            nodoActual = nodoInicial;
            for (int i = 0; i < 10; i++)
            {
                if (nodoActual == nodoInicial) 
                {
                    nodoActual = nodoActual.Siguiente;
                }
                datos += nodoActual.Valor + "\n";
                nodoActual = nodoActual.Siguiente;
            }
            return datos;
        }
    }
}
