using System.ComponentModel.DataAnnotations;

namespace testeef.Models{

    public class Pessoa{
        
        [Key]
        public int Id { get;set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Name { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Email { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Cor { get; set;}
    }
}