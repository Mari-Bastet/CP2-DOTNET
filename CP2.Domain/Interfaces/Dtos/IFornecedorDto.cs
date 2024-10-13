namespace CP2.Domain.Interfaces.Dtos
{
    public interface IFornecedorDto
    {
        /// <summary>
        /// Nome do fornecedor
        /// </summary>
        /// <example>João</example>
        public string Nome { get; set; }

        /// <summary>
        /// CNPJ do Fornecedor
        /// </summary>
        /// <example></example>
        public string CNPJ { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public DateTime CriadoEm { get; set; }
        void Validate();
    }
}
