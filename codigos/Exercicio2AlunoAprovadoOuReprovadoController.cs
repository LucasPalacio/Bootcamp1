using Microsoft.AspNetCore.Mvc;

namespace algoritmoOperadoresTernarios.Controllers
{
    public class Exercicio2AlunoAprovadoOuReprovadoController : ControllerBase
    {
        [HttpPost("AprovadoOuReprovado")]
        public string AprovadoOuReprovado(double nota)
        {
            string resultado;
            resultado = ((nota >= 0 && nota <= 10)) ?(nota >= 6) ? " Aprovado" : " Reprovado" : "informe um número entre 0 e 10";

            return $"A nota é {nota} o aluno está {resultado}";
        }
    }
}
