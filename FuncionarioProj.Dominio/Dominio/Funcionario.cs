using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioProj.Data.Dominio
{
    public class Funcionario
    {
        public Guid Id { get; set; }

        public string? NomeFuncionario { get; set; }

        public string? NomeEmpresa { get; set; }

        public string? Setor { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public bool Ativo { get; set; }
    }
}
