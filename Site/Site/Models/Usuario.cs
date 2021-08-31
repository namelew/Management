using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site
{
    public class Usuario
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public int privacidade { get; set; }
        public bool logado { get; set; }
    }
}
