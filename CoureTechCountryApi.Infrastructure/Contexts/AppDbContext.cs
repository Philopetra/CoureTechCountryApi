using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoureTechCountryApi.Domain.Entities;

namespace CoureTechCountryApi.Infrastructure.Contexts;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
	public DbSet<Country> Countries { get; set; }
	public DbSet<CountryDetail> CountryDetails { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseInMemoryDatabase("CountryDb");
	}
}
