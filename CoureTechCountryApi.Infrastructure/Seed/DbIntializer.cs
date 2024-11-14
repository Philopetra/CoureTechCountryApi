using CoureTechCountryApi.Domain.Entities;
using CoureTechCountryApi.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechCountryApi.Infrastructure.Seed;

public static class DbInitializer
{
	public static void Initialize(AppDbContext context)
	{
		context.Database.EnsureCreated();

		if (context.Countries.Any())
		{
			return; 
		}

		var countries = new List<Country>
		{
			new Country { Id = 1, CountryCode = "234", Name = "Nigeria", CountryIso = "NG" },
			new Country { Id = 2, CountryCode = "233", Name = "Ghana", CountryIso = "GH" },
			new Country { Id = 3, CountryCode = "229", Name = "Benin Republic", CountryIso = "BN" },
			new Country { Id = 4, CountryCode = "225", Name = "Côte d'Ivoire", CountryIso = "CIV" }
		};
		context.Countries.AddRange(countries);
		context.SaveChanges();

		var operators = new List<Operator>
		{
			new Operator { Id = 1, Name = "MTN Nigeria", Code = "MTN NG" },
			new Operator { Id = 2, Name = "Airtel Nigeria", Code = "ANG" },
			new Operator { Id = 3, Name = "9 Mobile Nigeria", Code = "ETN" },
			new Operator { Id = 4, Name = "Globacom Nigeria", Code = "GLO NG" },
			new Operator { Id = 5, Name = "Vodafone Ghana", Code = "Vodafone GH" },
			new Operator { Id = 6, Name = "MTN Ghana", Code = "MTN Ghana" },
			new Operator { Id = 7, Name = "Tigo Ghana", Code = "Tigo Ghana" },
			new Operator { Id = 8, Name = "MTN Benin", Code = "MTN Benin" },
			new Operator { Id = 9, Name = "Moov Benin", Code = "Moov Benin" },
			new Operator { Id = 10, Name = "MTN Côte d'Ivoire", Code = "MTN CIV" }
		};
		context.Set<Operator>().AddRange(operators);
		context.SaveChanges();

		var countryDetails = new List<CountryDetail>
		{
			new CountryDetail { Id = 1, CountryId = 1, OperatorId = 1 }, 
            new CountryDetail { Id = 2, CountryId = 1, OperatorId = 2 }, 
            new CountryDetail { Id = 3, CountryId = 1, OperatorId = 3 }, 
            new CountryDetail { Id = 4, CountryId = 1, OperatorId = 4 }, 
            new CountryDetail { Id = 5, CountryId = 2, OperatorId = 5 }, 
            new CountryDetail { Id = 6, CountryId = 2, OperatorId = 6 }, 
            new CountryDetail { Id = 7, CountryId = 2, OperatorId = 7 }, 
            new CountryDetail { Id = 8, CountryId = 3, OperatorId = 8 },
            new CountryDetail { Id = 9, CountryId = 3, OperatorId = 9 }, 
            new CountryDetail { Id = 10, CountryId = 4, OperatorId=10 } 
        };
		context.CountryDetails.AddRange(countryDetails);
		context.SaveChanges();
	}
}