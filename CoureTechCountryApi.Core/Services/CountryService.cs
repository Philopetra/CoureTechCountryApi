using CoureTechCountryApi.Core.Abstractions;
using CoureTechCountryApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechCountryApi.Core.Services;

public class CountryService : ICountryService
{
	private readonly ICountryRepository _countryRepository;

	public CountryService(ICountryRepository countryRepository)
	{
		_countryRepository = countryRepository;
	}

	public async Task<Country> GetCountryDetailsByPhoneNumberAsync(string phoneNumber)
	{
		// Clean input by removing spaces and trimming it.
		var cleanedInput = phoneNumber.Replace(" ", "").Trim();

		if (cleanedInput.Length < 3 || !int.TryParse(cleanedInput.Substring(0, 3), out int countryCode))
		{
			throw new ArgumentException("The first 3 characters must be a number e.g., 234");
		}

		var country = await _countryRepository.GetCountryByCodeAsync(countryCode.ToString());

		if (country == null)
		{
			throw new KeyNotFoundException("Country not found.");
		}

		return country;
	}
}
