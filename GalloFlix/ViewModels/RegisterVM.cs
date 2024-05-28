using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace GalloFlix.ViewModels
{
    public class  RegisterVM
    {
        [Display(Name ="Nome do usuário")]
        [Required(ErrorMessage ="Por favor, informe o nome do usuário")]
        public string Name {get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage ="Por favor, informe o email do usuário")]
        public string Email {get; set; }

        [Display(Name = "Aniversário")]
        [Required(ErrorMessage ="Por favor, informe o aniversário do usuário")]
        public string Birthday {get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Senha inválida, digite novamente")]
        public string Password {get; set; }

        [Display(Name = "Confirmar senha")]
        [Required(ErrorMessage = "Não é a mesma senha")]
        public string ConfirmPassword {get; set; }

        

   }
}


