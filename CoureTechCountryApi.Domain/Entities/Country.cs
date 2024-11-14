namespace CoureTechCountryApi.Domain.Entities;

public class Country : Entity
{
	public string CountryCode { get; set; }
	public string Name { get; set; }
	public string CountryIso { get; set; }

	public ICollection<CountryDetail> CountryDetails { get; set; }
}

