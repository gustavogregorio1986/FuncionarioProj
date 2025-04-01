namespace FuncionarioProj.Models
{
    public class FuncionarioView
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
