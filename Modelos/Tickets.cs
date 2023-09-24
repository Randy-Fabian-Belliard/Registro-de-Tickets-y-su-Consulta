using System.ComponentModel.DataAnnotations;

public class Tickets
{

    [Key]

    public int TicketId {get; set;}
    [Required(ErrorMessage = "Este campo es nesesario")]
    public DateTime Fecha {get; set;}
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
    [Required(ErrorMessage = "Este campo es necesario")]
    public string? Descripcion { get; set; }
}