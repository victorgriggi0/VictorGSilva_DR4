using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class PessoaModel : PageModel
    {
        public List<Pessoa> Pessoas { get; set; }

        public void OnGet()
        {

            Pessoas = new List<Pessoa>
            {
                new Pessoa { Name = "Victor", Age = 22, Cpf = "123" },
                new Pessoa { Name = "Jefferson", Age = 54, Cpf = "456" }
            };

        }
    }
}
