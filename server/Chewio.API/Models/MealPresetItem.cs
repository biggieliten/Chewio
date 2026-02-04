// Class representing one food item for a specific Meal Preset.
public class MealPresetItem
{
	public int Id { get; set; }
	public double Quantity { get; set; } // grams or ml

	public int MealPresetId { get; set; }
	public MealPreset MealPreset { get; set; }

	public int FoodItemId { get; set; }
	public Food FoodItem { get; set; }
}