using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Site
{
    public class Log
    {
        public int Id { get; set; }
        [DisplayName("Ação")]
        public int acao { get; set; }
        [DisplayName("Produto")]
        [ForeignKey("Id_Produto")]
        public virtual Produto produto { get; set; }
        [DisplayName("Quantidade")]
        public int quantidade { get; set; }
        [DisplayName("Data da Transação")]
        public DateTime horario { get; set; }

    }
}
