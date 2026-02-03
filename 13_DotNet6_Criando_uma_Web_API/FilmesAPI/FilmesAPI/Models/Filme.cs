using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "O Titulo do filme é obrigatorio")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O Gênero do filme é obrigatorio")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70,600, ErrorMessage ="A duracao deve ter entre 70 a 600 minutos")]
    public int Duracao { get; set; }
    
}
