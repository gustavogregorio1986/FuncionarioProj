using FuncionarioProj.Data.Context;
using FuncionarioProj.Data.Dominio;
using FuncionarioProj.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioProj.Data.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly DbContexto _db;

        public FuncionarioRepository(DbContexto db)
        {
            _db = db;
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            _db.Add(funcionario);
            _db.SaveChanges();
        }
    }
}
