using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _08_Forms.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Utilizador")]
        public string Nome { get; set; }
        public string Apelido { get; set; }
        [StringLength(10, MinimumLength = 4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Email obrigatório", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "Permitido máximo de 100 catacteres")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email errado!")]
        public string Email { get; set; }


    }

}
