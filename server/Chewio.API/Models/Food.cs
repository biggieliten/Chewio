// Class for food items. Either to be scanned by barcode or added manually.
public class Food
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public string Barcode { get; set; } = string.Empty;
	public string FoodType { get; set; } = string.Empty; // "Protein", "Vegetable", etc.

	// Nutritional info per 100g or standard serving
	public double Calories { get; set; }
	public double Protein { get; set; }
	public double Carbs { get; set; }
	public double Fat { get; set; }
	public double ServingSize { get; set; } = 100;
}