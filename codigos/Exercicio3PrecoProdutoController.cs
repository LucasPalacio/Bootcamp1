using Microsoft.AspNetCore.Mvc;

namespace algoritmoOperadoresTernarios.Controllers
{
    public class Exercicio3PrecoProdutoController : Controller
    {
        [HttpPost("desconto")]
        public string  desconto(double valor)
        {
            double desconto;
            desconto = (valor > 100) ? valor - (valor * 10 / 100) : desconto = valor;
            return $"O valor original é {valor} e esse é o descolto {desconto} ";
        }
    }
}
