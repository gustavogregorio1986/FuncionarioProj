using System.ComponentModel.DataAnnotations;

namespace FuncionarioProj.Models
{
    public class FuncionarioView
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome do Funcionario")]
        public string? NomeFuncionario { get; set; }

        [Display(Name = "Nome da Empresa")]
        public string? NomeEmpresa { get; set; }

        public string? Setor { get; set; }

        [Display(Name = "Data de Inicio")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Data de Termino")]
        public DateTime DataTermino { get; set; }

        public bool Ativo { get; set; }
    }
}
