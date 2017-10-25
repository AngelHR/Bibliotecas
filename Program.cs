using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca B1=new Biblioteca("Los Pinos");
            Biblioteca B2 = new Biblioteca("El Tiempo");
            Biblioteca B3 = new Biblioteca("TESE Biblioteca");
            int p;
            do {
                Console.WriteLine("Bienvenido a Explora BiBliTESE:\nQue Biblioteca desea Visitar:\n" +
                    $"[1]{B1.Name}\n[2]{B2.Name}\n[3]{B3.Name}");
                p = int.Parse(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        Menu(B1);
                        break;
                    case 2:
                        Menu(B2);
                        break;
                    case 3:
                        Menu(B3);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida(*.*)");
                        break;
                }
            }while(true);

        }
        public static void Menu(Biblioteca p)
        {
            int t;
            Console.WriteLine("Que desea hacer?\n[1]Dejar libro\n[2]Sacar libro\n[3]Consultar");
            t = int.Parse(Console.ReadLine());
            switch (t)
            {
                case 1:
                    string N, E, A;
                    Console.WriteLine("Nombre:");
                    N = Console.ReadLine();
                    Console.WriteLine("Editorial:");
                    E = Console.ReadLine();
                    Console.WriteLine("Autor:");
                    A = Console.ReadLine();
                    p.Agregar(new Libro(N,A,E));
                    break;
                case 2:
                    p.Eliminar(0);
                    break;
                case 3:
                    int r;
                    string n, a, e;
                    Console.WriteLine("Que datos conoces?\n[1]Nombre\n[2]Nombre-Editorial\n[3]Autor-Nombre");
                    r = int.Parse(Console.ReadLine());
                    switch (r)
                    {
                        case 1:
                            Console.WriteLine("Nombre:");
                            n = Console.ReadLine();
                            p.Consulta(n);
                            break;
                        case 2:
                            Console.WriteLine("Nombre:");
                            n = Console.ReadLine();
                            Console.WriteLine("Editorial:");
                            e = Console.ReadLine();
                            p.Consulta(n,e);
                            break;
                        case 3:
                            Console.WriteLine("Nombre:");
                            n = Console.ReadLine();
                            Console.WriteLine("Autor:");
                            a = Console.ReadLine();
                            p.Consulta(n,"",a);
                            break;

                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}

