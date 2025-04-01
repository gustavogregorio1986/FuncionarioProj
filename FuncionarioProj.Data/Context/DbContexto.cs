using FuncionarioProj.Data.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionarioProj.Data.Context
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions options)
            : base(options) 
        {
            
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
