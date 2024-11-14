using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechCountryApi.Core.Services;

public class ScoreService
{
	public int CalculateScore(int[] numbers)
	{
		if (numbers == null)
		{
			throw new ArgumentNullException(nameof(numbers), "Input array cannot be null.");
		}

		return numbers.Sum(number =>
		{
			if (number == 8) return 5; 
			return number % 2 == 0 ? 1 : 3; 
		});
	}
}