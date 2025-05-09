using Microsoft.AspNetCore.Mvc;

namespace algoritmoOperadoresTernarios.Controllers
{
    public class Exercicio1ParImparController : ControllerBase
    {
        [HttpPost("VerificarNumeroParImpar")]
        public String VerificarNumeroParImpar(Int32 numero)
        {
            string resultado;
            //if (numero % 2 == 0)
            //{
            //    resultado = "é Par";
            //}
            //else {
            //    resultado = "é impar";
            //}
            //usando operadores ternários
            resultado = (numero % 2 == 0) ?"Par" : "Impar";
            return $"O {numero} é {resultado}";
        }
    }
}
