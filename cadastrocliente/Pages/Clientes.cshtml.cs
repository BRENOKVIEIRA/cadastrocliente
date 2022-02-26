using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace cadastrocliente.Pages
{
    public class ClientesModel : PageModel
    {
        public IList<Cliente> Clientes { get; set; }

        public ClientesModel()
        {
            Clientes = new List<Cliente>();
        }

        public void OnGet()
        {
            Clientes.Add(new Cliente() { Id = 1, Name = "Diego" });
            Clientes.Add(new Cliente() { Id = 2, Name = "Breno" });
            Clientes.Add(new Cliente() { Id = 3, Name = "Gabi" });
            Clientes.Add(new Cliente() { Id = 4, Name = "Ellen" });
            Clientes.Add(new Cliente() { Id = 5, Name = "Cintia" });
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
