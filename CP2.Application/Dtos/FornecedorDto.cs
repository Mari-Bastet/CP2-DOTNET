using CP2.Domain.Interfaces.Dtos;
using FluentValidation;

namespace CP2.Application.Dtos
{
    public class FornecedorDto : IFornecedorDto
    {
        /// <summary>
        /// 
        /// </summary>
        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public DateTime CriadoEm { get; set; }

        public void Validate()
        {
            var validateResult = new FornecedorDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class FornecedorDtoValidation : AbstractValidator<FornecedorDto>
    {
        public FornecedorDtoValidation()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Nome é obrigatório.")
                .Length(2, 100).WithMessage("Nome deve ter entre 2 e 100 caracteres.");

            RuleFor(x => x.CNPJ)
                .NotEmpty().WithMessage("CNPJ é obrigatório.");

            RuleFor(x => x.Endereco)
                .NotEmpty().WithMessage("Endereço é obrigatório.")
                .Length(5, 200).WithMessage("Endereço deve ter entre 5 e 200 caracteres.");

            RuleFor(x => x.Telefone)
                .NotEmpty().WithMessage("Telefone é obrigatório.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email é obrigatório.")
                .EmailAddress().WithMessage("Email deve ter um formato válido.");

        }
    }
}
