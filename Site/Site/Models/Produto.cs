using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site
{
    public class Produto
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public int tipo { get; set; }
        public int quantidade { get; set; }
        public float preco_unitario { get; set; }
    }
}
