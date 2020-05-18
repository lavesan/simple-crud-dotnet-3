using System.ComponentModel.DataAnnotations;

namespace SimpleCrud.Models
{
    public class User
    {

        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^[a-zA-Z\u00C0-\u00FF ]+$", ErrorMessage = "Nome inválido")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^\(?\d{2}\)?$", ErrorMessage = "DDD inválido")]
        public string Ddd { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [RegularExpression(@"^\d{4,5}-?\d{4}$", ErrorMessage = "Telefone inválido")]
        public string PhoneNumber {get; set; }

    }
}