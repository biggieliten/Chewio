using System.ComponentModel.DataAnnotations;

public class User
{
	public int Id { get; set; }

	public required string Username { get; set; }


	public required string Email { get; set; }

	public required string Password { get; set; }

	public bool AutoAppliedNutrientGoal { get; set; } = false;

	public List<NutrientTarget> DailyNutrientTarget { get; set; } = new();

	public List<MealPreset> MealPresets { get; set; } = new();

	public List<MealLog> MealLogs { get; set; } = new();
}