using FuncionarioProj.Data.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioProj.Data.Repository.Interface
{
    public interface IFuncionarioRepository
    {
        void AdicionarFuncionario(Funcionario funcionario);
    }
}
