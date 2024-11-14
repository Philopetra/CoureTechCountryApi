using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoureTechCountryApi.Domain.Entities;

namespace CoureTechCountryApi.Core.Abstractions;

public interface ICountryRepository
{
	Task<Country> GetCountryByCodeAsync(string code);
}