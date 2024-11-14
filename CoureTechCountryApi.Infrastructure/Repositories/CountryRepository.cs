using CoureTechCountryApi.Domain.Entities;
using CoureTechCountryApi.Infrastructure.Contexts;
using CoureTechCountryApi.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoureTechCountryApi.Infrastructure.Repositories;

public class CountryRepository : ICountryRepository
{
	private readonly AppDbContext _context;

	public CountryRepository(AppDbContext context)
	{
		_context = context;
	}

	public async Task<Country> GetCountryByCodeAsync(string code)
	{
		return await _context.Countries
							 .Include(c => c.CountryDetails)
							 .ThenInclude(cd => cd.Operator) // Include related Operators
							 .FirstOrDefaultAsync(c => c.CountryCode == code);
	}
}