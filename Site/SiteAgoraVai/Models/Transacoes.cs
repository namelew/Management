using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteAgoraVai.Models
{
    public class Transacoes
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [ForeignKey("Id_Produto")]
        public Produto Produto { get; set; }
        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "O campo não aceita valores negativos")]
        public float Valor { get; set; }
    }
}
