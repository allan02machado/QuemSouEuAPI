using Microsoft.AspNetCore.Mvc;
using QuemSouEuAPI.Models;

namespace QuemSouEuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuemSouEuController : ControllerBase
    {
        [HttpGet]
        public PessoaModel Get()
        {
            PessoaModel eu = new PessoaModel();

            eu.Nome = "Allan";
            eu.Sobrenome = "Cássio";
            eu.UsuarioGitHub = "allan02machado";

            return eu;
        }
    }
}