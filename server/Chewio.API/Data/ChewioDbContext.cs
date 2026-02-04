using Microsoft.EntityFrameworkCore;

class ChewioDbContext : DbContext
{
	public ChewioDbContext(DbContextOptions options) : base(options) { }

	DbSet<User> Users => Set<User>();

	DbSet<MealLog> LoggedMeals => Set<MealLog>();

	DbSet<Food> FoodItems => Set<Food>();

	DbSet<MealPreset> MealPresets => Set<MealPreset>();

	DbSet<NutrientTarget> DailyNutrientTargets => Set<NutrientTarget>();

}