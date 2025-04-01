using FuncionarioProj.Data.Dominio;
using FuncionarioProj.Models;
using FuncionarioProj.Servico.Servico.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FuncionarioProj.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioServico _funcionarioServico;

        public FuncionarioController(IFuncionarioServico funcionarioServico)
        {
            _funcionarioServico = funcionarioServico;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Funcionario funcionario)
        {
            try
            {
                FuncionarioView funcionarioView = new FuncionarioView();
                funcionarioView.NomeFuncionario = funcionario.NomeFuncionario;
                funcionarioView.NomeEmpresa = funcionario.NomeEmpresa;
                funcionarioView.Setor = funcionario.Setor;  
                funcionarioView.DataInicio = funcionario.DataInicio;
                funcionarioView.DataTermino = funcionario.DataTermino;
                funcionarioView.Ativo = funcionario.Ativo;

                _funcionarioServico.AdicionarFuncionario(funcionario);

                return RedirectToAction("Cadastrar");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            return View(funcionario);
        }
    }
}
