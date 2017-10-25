using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    class Libro
    {
        public string Name { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Npagi { get; set; }

        public Libro(string nam,string aut,string edi,int page=186  )
        {
            Name = nam;
            Autor = aut;
            Editorial = edi;
            Npagi = page;
        }

    }
}
