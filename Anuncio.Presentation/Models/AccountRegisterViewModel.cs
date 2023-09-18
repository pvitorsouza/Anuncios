using System.ComponentModel.DataAnnotations;

namespace Anuncio.Presentation.Models
{
    public class AccountRegisterViewModel
    {
        [MinLength(8, ErrorMessage ="Por favor, informe no mínimo {1} caracteres.")]
        [Required(ErrorMessage ="Por favor, informe o nome.")]
        public string? Nome { get; set; }


        [EmailAddress(ErrorMessage ="Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage ="Por favor, informe o email.")]
        public string? Email { get; set; }



        [Required(ErrorMessage ="Por favor, informe a senha")]
        public string? Senha { get; set; }



        [Required(ErrorMessage ="Por favor, confirme a senha.")]
        public string? SenhaConfirm { get; set; }
    }
}
