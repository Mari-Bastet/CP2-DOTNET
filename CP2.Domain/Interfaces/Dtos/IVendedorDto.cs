namespace CP2.Domain.Interfaces.Dtos
{
    public interface IVendedorDto
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public DateTime DataContratacao { get; set; }
        public decimal ComissaoPercentual { get; set; }
        public decimal MetaMensal { get; set; }
        public DateTime CriadoEm { get; set; }

        void Validate();
    }
}
