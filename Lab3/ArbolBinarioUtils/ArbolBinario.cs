using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.ArbolBinarioUtils
{
    public class ArbolBinario<T>
    {
        private Nodo<T> Raiz;

        public void Agregar(T valor, string nuevaLlave)
        {
            if(Raiz == null)
            {
                Nodo<T> nuevoNodo = new Nodo<T>();
                nuevoNodo.Valor = valor;
                nuevoNodo.Llave = nuevaLlave;
                Raiz = nuevoNodo;
            }
            else {
                Agregar(valor, nuevaLlave, Raiz);
            }
        }

        private void Agregar(T valor, string nuevaLlave, Nodo<T> nodo)
        {
            
            Nodo<T> tmp = nodo;
            //nuevaLlave < tmp.llave
            if (nuevaLlave.CompareTo(tmp.Llave) == -1)
            {
                if (tmp.Izquierda == null)
                {
                    Nodo<T> nuevoNodo = new Nodo<T>();
                    nuevoNodo.Valor = valor;
                    nuevoNodo.Llave = nuevaLlave;
                    tmp.Izquierda = nuevoNodo;
                }
                else
                {
                    Agregar(valor, nuevaLlave, tmp.Izquierda);
                }
            }
            else
            {
                if (tmp.Derecha == null)
                {
                    Nodo<T> nuevoNodo = new Nodo<T>();
                    nuevoNodo.Valor = valor;
                    nuevoNodo.Llave = nuevaLlave;
                    tmp.Derecha = nuevoNodo;
                }
                else
                {
                    Agregar(valor, nuevaLlave, tmp.Derecha);
                }
            }
        }

        public List<T> Buscar(string valor)
        {            
            List<T> superior = new List<T>();
            InfoIndice nuevo = new InfoIndice();
            
            Inorden(valor, Raiz, superior);
            
            return superior;           

            //TODO: recorer arbol y evaluar valor

        }
        public List<T> BuscarPorCantidad()
        {
            List<T> superior = new List<T>();
            InfoIndice nuevo = new InfoIndice();
            absoluto("a", Raiz, superior);
            return superior;
        }
        //Recorre todos los valores del arbol
        public void absoluto(string valor, Nodo<T> a, List<T> superior)
        {
            if (a != null)
            {
                superior.Add(a.Valor);
                absoluto(valor, a.Izquierda, superior);
                absoluto(valor, a.Derecha, superior);
            }
        }

        

        public void Inorden(string valor, Nodo<T> a, List<T> superior)
        {
            if (a != null)
            {
                
                if (a.Llave.Contains(valor))
                {
                    
                    superior.Add(a.Valor);
                                     
                    
                }
                Inorden(valor, a.Izquierda, superior);                
                Inorden(valor, a.Derecha, superior);
            }           

        }


        public void EliminarNodo(Nodo<T> Raiz, string valor)
        {
            
            if (Raiz != null)
            {
                if (valor.CompareTo(Raiz.Llave) == -1)
                {
                    EliminarNodo(Raiz.Izquierda, valor);
                }
                else
                {
                    if (valor.CompareTo(Raiz.Llave) == 1)
                    {
                        EliminarNodo(Raiz.Izquierda, valor);
                    }
                    else
                    {
                        //Si lo Encontro
                        Nodo<T> NodoEliminar = Raiz;
                        if (NodoEliminar.Derecha == null)
                        {
                            Raiz = NodoEliminar.Izquierda;
                        }
                        else
                        {
                            if (NodoEliminar.Izquierda == null)
                            {
                                Raiz = NodoEliminar.Derecha;
                            }
                            else
                            {
                                Nodo<T> AuxiliarNodo = null;
                                Nodo<T> Auxiliar = Raiz.Izquierda;
                                bool Bandera = false;
                                while (Auxiliar.Derecha != null)
                                {
                                    AuxiliarNodo = Auxiliar;
                                    Auxiliar = Auxiliar.Derecha;
                                    Bandera = true;
                                }
                                Raiz.Valor = Auxiliar.Valor;
                                NodoEliminar = Auxiliar;
                                if (Bandera == true)
                                {
                                    AuxiliarNodo.Derecha = Auxiliar.Izquierda;
                                }
                                else
                                {
                                    Raiz.Izquierda = Auxiliar.Izquierda;
                                }
                            }
                        }
                    }
                }
            }
            
        }
        //Método para la eliminación generica (solo llamarlo para que sea generica)
        public void Suprimir(string valor)
        {
            EliminarNodo(Raiz, valor);
        }


    }
}
