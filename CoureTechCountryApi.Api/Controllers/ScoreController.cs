using CoureTechCountryApi.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoureTechCountryApi.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ScoreController : ControllerBase
{
	private readonly ScoreService _scoreService;

	public ScoreController(ScoreService scoreService)
	{
		_scoreService = scoreService;
	}

	[HttpPost("calculate")]
	public IActionResult CalculateScore([FromBody] int[] numbers)
	{
		try
		{
			var score = _scoreService.CalculateScore(numbers);
			return Ok(new { score });
		}
		catch (ArgumentNullException ex)
		{
			return BadRequest(ex.Message);
		}
		catch (Exception ex)
		{
			return StatusCode(500, "An unexpected error occurred: " + ex.Message);
		}
	}
}
