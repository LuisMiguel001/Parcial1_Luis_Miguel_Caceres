using Microsoft.EntityFrameworkCore;
using Parcial1_Luis_Miguel_Caceres.Models;

namespace Parcial1_Luis_Miguel_Caceres.DAL;

public class Context : DbContext
{
	public Context(DbContextOptions<Context> Options)
		: base(Options) { }

	public DbSet<Ingresos> Ingresos { get; set; }
}
