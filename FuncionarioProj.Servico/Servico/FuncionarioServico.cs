using FuncionarioProj.Data.Dominio;
using FuncionarioProj.Data.Repository.Interface;
using FuncionarioProj.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioProj.Servico.Servico
{
    public class FuncionarioServico : IFuncionarioServico
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioServico(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            _funcionarioRepository.AdicionarFuncionario(funcionario);
        }
    }
}
