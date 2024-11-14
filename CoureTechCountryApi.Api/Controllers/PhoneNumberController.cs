using CoureTechCountryApi.Core.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CoureTechCountryApi.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PhoneNumberController : ControllerBase
{
	private readonly ICountryService _countryService;

	public PhoneNumberController(ICountryService countryService)
	{
		_countryService = countryService;
	}

	[HttpGet("{phoneNumber}")]
	public async Task<IActionResult> GetCountryDetails(string phoneNumber)
	{
		try
		{
			var countryDetails = await _countryService.GetCountryDetailsByPhoneNumberAsync(phoneNumber);

			return Ok(new
			{
				number = phoneNumber,
				country = new
				{
					countryCode = countryDetails.CountryCode,
					name = countryDetails.Name,
					countryIso = countryDetails.CountryIso,
					countryDetails = countryDetails.CountryDetails.Select(cd => new
					{
						operatorName = cd.Operator.Name,
						operatorCode = cd.Operator.Code
					}).ToList()
				}
			});
		}
		catch (ArgumentException ex)
		{
			return BadRequest(ex.Message);
		}
		catch (KeyNotFoundException)
		{
			return NotFound("Country not found.");
		}
	}
}