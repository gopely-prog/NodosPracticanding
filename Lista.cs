using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Lista
    {
        Nodo primero = null;
        public void InsertarAlFinal(int num) 
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = num;
            if (primero == null) 
            {
                primero = nuevo;
            }
            else 
            {
                Nodo actual = primero;
                while (actual.Siguiente != null) 
                {
                    actual=actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }
        public void InsertarAlInicio(int num) 
        {
            Nodo nuevo=new Nodo();
            nuevo.Dato = num;
            if (primero == null)
            {
                primero = nuevo;
            }
            else 
            {
                nuevo.Siguiente=primero;
                primero = nuevo;
            }
        }
        public void Mostrar() 
        {
            Nodo actual = primero;
            while (actual != null) 
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            }
        }
        public void Contar() 
        {
            int contador = 0;
            Nodo actual = primero;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            Console.WriteLine("Total de nodos: " + contador);
        }
        public void Buscar(int num) 
        {
            Nodo actual = primero;
            int contador = 1;
            while (actual != null) 
            {
                if (actual.Dato == num) 
                {
                    Console.WriteLine("El numero " + num + " se encuentra en la posicion: " + contador);
                    return;
                }
                actual = actual.Siguiente;
                contador++;
            }
            Console.WriteLine("El numero " + num + " no se encuentra en la lista.");
        }
        public void EliminarPrimero() 
        {
            Nodo actual = primero;
            if (primero == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else 
            {
                primero = primero.Siguiente;
                actual.Siguiente = null;
            }
        }
        public void EliminarUltimo() 
        {
            Nodo actual = primero;
            if (primero == null)
            {
                Console.WriteLine("No hay lista");
            }
            else if (primero.Siguiente == null)
            {
                Console.WriteLine("Se eliminó el único nodo: " + primero.Dato);
                primero = null;
            }
            else 
            {
                Nodo anterior = null;
                while (actual.Siguiente != null) 
                {
                    anterior = actual;
                    actual = actual.Siguiente;
                }
                    anterior.Siguiente = null;
            }
        }
        public void EliminarPorValor(int num)
        {
            Nodo actual = primero;
            Nodo anterior = null;

            while (actual != null)
            {
                if (actual.Dato == num)
                {
                    if (anterior == null)
                    {
                        primero = actual.Siguiente;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    return; 
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

            Console.WriteLine("El valor no se encontró en la lista.");
        }
        public void OrdenarMenorMayor() 
        {
            if (primero == null || primero.Siguiente == null) return; 
            bool cambiado;
            do 
            {
                cambiado = false;
                Nodo actual = primero;
                while (actual.Siguiente != null) 
                {
                    if (actual.Dato > actual.Siguiente.Dato) 
                    {
                        int temp = actual.Dato;
                        actual.Dato = actual.Siguiente.Dato;
                        actual.Siguiente.Dato = temp;
                        cambiado = true;
                    }
                    actual = actual.Siguiente;
                }
            } while (cambiado);
        }
    }   
}
