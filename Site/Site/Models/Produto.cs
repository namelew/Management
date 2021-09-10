using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site
{
    public class Produto
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Nome")]
        public string nome { get; set; }
        [Required]
        [DisplayName("Tipo")]
        [Range(1, int.MaxValue, ErrorMessage = "O atributo somente aceita valores maiores ou iguais a 1")]
        public int tipo { get; set; }
        [Required]
        [DisplayName("Quantidade")]
        [Range(0, int.MaxValue, ErrorMessage ="O campo não aceita valores negativos")]
        public int quantidade { get; set; }
        [Required]
        [Range(0, float.MaxValue, ErrorMessage = "O campo não aceita valores negativos")]
        [DisplayName("Preço Unitário")]
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public float preco_unitario { get; set; }

        public static implicit operator Produto(Log v)
        {
            throw new NotImplementedException();
        }
    }
}
