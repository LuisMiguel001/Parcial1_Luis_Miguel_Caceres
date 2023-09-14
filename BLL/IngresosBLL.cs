using Microsoft.EntityFrameworkCore;
using Parcial1_Luis_Miguel_Caceres.DAL;
using Parcial1_Luis_Miguel_Caceres.Models;
using System.Linq.Expressions;

namespace Parcial1_Luis_Miguel_Caceres.BLL;

public class IngresosBLL
{
	private readonly Context _context;

	public IngresosBLL(Context context)
	{
		_context = context;
	}

	public bool Existe(int ingresoId)
	{
		return _context.Ingresos.Any(s => s.IngresosId == ingresoId);
	}

	public bool Insertar(Ingresos ingreso)
	{
		_context.Ingresos.Add(ingreso);
		int cantidad = _context.SaveChanges();
		return cantidad > 0;
	}

	public bool Modificar(Ingresos ingreso)
	{
		_context.Update(ingreso);
		int cantidad = _context.SaveChanges();
		return cantidad > 0;
	}

	public bool Guardar(Ingresos ingreso)
	{
		if (!Existe(ingreso.IngresosId))
			return Insertar(ingreso);
		else
			return Modificar(ingreso);
	}

	public bool Eliminar(Ingresos ingreso)
	{
		_context.Ingresos.Remove(ingreso);
		int cantidad = _context.SaveChanges();
		return cantidad > 0;
	}

	public Ingresos? Buscar(int ingresoId)
	{
		return _context.Ingresos
			.AsNoTracking()
			.FirstOrDefault(s => s.IngresosId == ingresoId);
	}

	public List<Ingresos> GetList(Expression<Func<Ingresos, bool>> Criterio)
	{
		return _context.Ingresos
			.Where(Criterio)
			.AsNoTracking()
			.ToList();
	}
}