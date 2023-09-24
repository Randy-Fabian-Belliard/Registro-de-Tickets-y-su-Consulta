using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Tickets
{
    [Key]

    public int TicketsId { get; set; }
    [Required(ErrorMessage = "Este campo es necesario")]
    public DateTime Fecha { get; set; } = DateTime.Today;
    [Required(ErrorMessage = "Este campo es necesario")]
    public int ClienteId { get; set; }
    [Required(ErrorMessage = "Este campo es necesario")]
    public int SistemaId { get; set; }
    [Required(ErrorMessage = "Este campo necesario")]
    public int PrioridadId { get; set; } 

    [Required(ErrorMessage = "Este campo es necesario")]
    public string? SolicitadoPor { get; set; }

    [Required(ErrorMessage = "Este campo es necesario")]
    public string? Asunto { get; set; }

    [Required(ErrorMessage = "Este campo")]
    public string? Descripcion { get; set; }
 
}