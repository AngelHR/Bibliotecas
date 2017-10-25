using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    class Biblioteca
    {
        public string Name { get; set; }
        public Biblioteca(string p)
        {
            Name = p;
        }
        List<Libro> lis = new List<Libro>();

        public void Agregar(Libro p)
        {
            lis.Add(p);
            Console.WriteLine("Añadido Realizado\n");
        }

        public void Eliminar(int index)
        {
            lis.RemoveAt(index);
            Console.WriteLine("Eliminacion Realizada\n");
        }

        public void Consulta(String Nom = "", string Edito = "", string Aut = "")
        {
            foreach (Libro item in lis) {
                if (Edito==item.Editorial && Nom == item.Name || Aut==item.Autor && Nom == item.Name|| Nom == item.Name ) { 

                Console.WriteLine($"Titulo de Libro: {item.Name}");
                Console.WriteLine($"Autor: {item.Autor}");
                Console.WriteLine($"Editorial: {item.Editorial}");
                Console.WriteLine($"Numero de paguinas: {item.Npagi}");
                }
            }

        }

    }
}