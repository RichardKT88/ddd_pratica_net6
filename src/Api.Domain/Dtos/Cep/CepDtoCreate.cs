using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Cep
{
    public class CepDtoCreate
    {
        [Required(ErrorMessage = "CEP é campo Obrigatório")]
        public string? Cep { get; set; }
        [Required(ErrorMessage = "Logradouro é campo Obrigatório")]
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        [Required(ErrorMessage = "Município é campo Obrigatório")]
        public Guid MunicipioId { get; set; }
    }
}
