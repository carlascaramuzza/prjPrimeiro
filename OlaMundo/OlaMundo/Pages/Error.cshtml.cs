using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OlaMundo.Pages
{
   public class ErrorModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Qual � a minha mensagem a declarar?";
            Message = "onde estou?";
        }
    }
}
