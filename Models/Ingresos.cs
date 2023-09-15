using System.ComponentModel.DataAnnotations;

namespace Parcial1_Luis_Miguel_Caceres.Models;

public class Ingresos
{
	[Key]

	public int IngresosId { get; set; }

	[Required(ErrorMessage ="La Fecha es requerido")]
	public DateTime Fecha { get; set; }

    [Required(ErrorMessage = "El Concepto es requerido")]
    public string? Concepto { get; set; }

    [Required(ErrorMessage = "El Monto es requerido")]
    public Decimal Monto { get; set; }
}
