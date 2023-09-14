using System.ComponentModel.DataAnnotations;

namespace Parcial1_Luis_Miguel_Caceres.Models;

public class Ingresos
{
	[Key]

	public int IngresosId { get; set; }

	public DateTime Fecha { get; set; }

	public string? Concepto { get; set; }

	public Decimal Monto { get; set; }
}
