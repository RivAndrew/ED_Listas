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
            nuevoNodo.Anterior = nodoActual;
            nuevoNodo.Siguiente = nodoInicial;
            nodoInicial.Anterior = nuevoNodo;
        }
        public void AgregarNodoInicio(string valor)
        {
            nodoActual = nodoInicial;
            Nodo nuevoNodo = new Nodo(valor, nodoInicial, nodoActual.Siguiente);
            if (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                nodoActual.Anterior = nuevoNodo;
            }
            nodoActual = nodoInicial;
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
                            && nodoBusqueda.Valor != valor && nodoBusqueda.Siguiente != nodoInicial)
                {
                    nodoBusqueda = nodoBusqueda.Siguiente;
                    if (nodoBusqueda.Valor == valor)
                    {
                        return nodoBusqueda.Anterior;
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
                    nodoActual.Anterior.Siguiente = nodoActual.Siguiente;
                    nodoActual.Siguiente.Anterior = nodoActual.Anterior;
                    nodoActual.Siguiente = null;
                    nodoActual.Anterior = null;
                }
            }
        }
        public string RecorrerListaInversa()
        {
            string valores = string.Empty;
            while (nodoActual.Siguiente != null && nodoActual.Siguiente != nodoInicial)
            {
                nodoActual = nodoActual.Siguiente;
            }
            while (nodoActual.Anterior != null && nodoActual.Anterior != nodoInicial)
            {
                valores += $"{nodoActual.Valor}\n";
                nodoActual = nodoActual.Anterior;
            }
            valores += $"{nodoActual.Valor}\n";
            return valores;
        }
        public string imprimirPrimerUltimoSiguiente()
        {
            string datos = string.Empty;
            nodoActual = nodoInicial.Siguiente;
            //nodoActual = nodoActual.Siguiente;
            datos += nodoActual.Valor + "\n";
            while (nodoActual.Siguiente != null && nodoActual.Siguiente != nodoInicial)
            {
                nodoActual = nodoActual.Siguiente;
            }
            datos += nodoActual.Valor + "\n";
            nodoActual = nodoActual.Siguiente;
            datos += nodoActual.Valor + "\n";
            return datos;
        }
        public string imprimirUltimoPrimerAnterior()
        {
            string datos = string.Empty;
            nodoActual = nodoInicial;
            datos += nodoActual.Anterior.Valor + "\n";
            datos += nodoActual.Valor + "\n";
            datos += nodoActual.Siguiente.Valor + "\n";
            return datos;
        }

        // Se imprimen todos los Nodos saltandose el nodoInicial
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
        public string ImprimirCicloInverso()
        {
            string datos = string.Empty;
            nodoActual = nodoInicial;
            for (int i = 0; i < 10; i++)
            {
                if (nodoActual == nodoInicial)
                {
                    nodoActual = nodoActual.Anterior;
                }
                datos += nodoActual.Valor + "\n";
                nodoActual = nodoActual.Anterior;
            }
            return datos;
        }
    }
}
