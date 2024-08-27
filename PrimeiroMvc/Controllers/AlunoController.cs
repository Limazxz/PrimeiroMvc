using Microsoft.AspNetCore.Mvc;
using PrimeiroMvc.Models;

namespace PrimeiroMvc.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Pedro Lima", "silaelima557@gmail.com", 123456);
            Aluno a2 = new Aluno(2, "Geromel", "gero.mel@gmail.com", 789102);
            Aluno a3 = new Aluno(3, "Léo Pelé", "peo.lele@gmail.com", 341267);
            Aluno a4 = new Aluno(4, "Alan Franco", "alan.franco23@gmail.com", 123456);
            Aluno a5 = new Aluno(5, "Arboleda", "arboledazagtri@gmail.com", 298750);

            List<Aluno> listaAlunos = new List<Aluno>();
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);

            return View(listaAlunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
