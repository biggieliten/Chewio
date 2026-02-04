public class MealPreset
{
	public required string Name { get; set; }
	public string Description { get; set; } = string.Empty;
	public required List<MealPresetItem> mealPresetItems;

	DateTime CreatedAt { get; set; }

}