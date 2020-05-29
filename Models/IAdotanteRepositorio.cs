using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{
	interface IAdotanteRepositorio
	{
		IQueryable<Adotante> Adotantes { get; }
	}
}
