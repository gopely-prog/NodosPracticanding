using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.InsertarAlFinal(30);
            lista.InsertarAlFinal(50);
            lista.InsertarAlInicio(1239813210);
            lista.InsertarAlInicio(26);
            lista.InsertarAlFinal(5);
            lista.Mostrar();
            lista.Contar();
            lista.Buscar(50);
            lista.Buscar(100); 
            lista.EliminarUltimo();
            Console.ReadKey();
            Console.Clear();
            lista.Mostrar();
            lista.Contar();
            lista.Buscar(30);
            lista.Buscar(100);
            lista.EliminarPorValor(50);
            Console.ReadKey();
            Console.Clear();
            lista.Mostrar();
            Console.WriteLine("He avanzado con mi repositorio");
        }
    }
}
