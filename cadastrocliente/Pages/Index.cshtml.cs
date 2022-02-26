using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace cadastrocliente.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public DateTime MinhaData = DateTime.Now;

        // Antes de chegar no HTML, PRECISO CRIAR ALGO?
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // Cheguei no HTML
        public void OnGet()
        {
            Console.WriteLine("Entrei no metodo GET da pagina INDEX");
        }
    }
}
