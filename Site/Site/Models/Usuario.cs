using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Nome")]
        public string nome { get; set; }
        [Required]
        [DisplayName("Senha")]
        public string senha { get; set; }
        [Required]
        [Range(1,3, ErrorMessage = "Defina um nível de Privilégios para o Usuário")]
        [DisplayName("Nível de Privilégios")]
        public int privacidade { get; set; }
        [Required]
        [DisplayName("Estado Atual")]
        public bool logado { get; set; }

        public Usuario()
        {
            privacidade = 1;
            logado = false;
        }
    }
}
