using Microsoft.AspNetCore.Mvc;

namespace algoritmoOperadoresTernarios.Controllers
{
    public class negativoPositivoOuZeroController : Controller
    {
        [HttpPost("PositivoOuNegativoOuZERO")]
        public string PositivoOuNegativoOuZero(Int32 numero)
        {
            string resultado;
            resultado = (numero == 0) ? "éle é zero" : (numero > 0) ? "ele é positivo" : "ele é negativo";
            return $"O numero é {resultado}";
        }
    }
}
