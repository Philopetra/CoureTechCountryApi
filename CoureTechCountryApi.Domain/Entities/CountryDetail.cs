using System.ComponentModel.DataAnnotations.Schema;

namespace CoureTechCountryApi.Domain.Entities;

public class CountryDetail : Entity
{
	[ForeignKey(nameof(CountryId))]
	public int CountryId { get; set; }

	[ForeignKey(nameof(OperatorId))]
	public int OperatorId { get; set; }

	public Country Country { get; set; }
	public Operator Operator { get; set; }
}

