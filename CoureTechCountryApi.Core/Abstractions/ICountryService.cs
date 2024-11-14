using CoureTechCountryApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechCountryApi.Core.Abstractions;

public interface ICountryService
{
	Task<Country> GetCountryDetailsByPhoneNumberAsync(string phoneNumber);
}
