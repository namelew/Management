using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteAgoraVai.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [ForeignKey("Id_Categoria")]
        public Categoria Categoria { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "O campo não aceita valores negativos ou zero")]
        public int Quantidade { get; set; }
        [Required]
        [DisplayName("Preço Unitério")]
        [Range(0, float.MaxValue, ErrorMessage = "O campo não aceita valores negativos")]
        public float PrecoUnitario {get; set;}
    }
}
