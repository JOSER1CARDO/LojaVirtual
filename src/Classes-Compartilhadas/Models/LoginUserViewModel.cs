﻿using System.ComponentModel.DataAnnotations;

namespace Classes_Compartilhadas.Models
{
    public class LoginUserViewModel
    {
        
        [Required(ErrorMessage = "o campo {0} é obrigatorio")]
        [EmailAddress(ErrorMessage = "o campo {0} esta no fomrato invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "o campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 6)]
        public string Password { get; set; }
    
    }
}
