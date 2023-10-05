using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicCrud.Models
{

    [Table("Usuario")]
    public class UsuarioModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Necessário informar o nome do usuário")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Necesário informar a data de nascimento do usuário.")]
        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
      


    }
}
