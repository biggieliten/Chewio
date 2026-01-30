using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
	options.AddDefaultPolicy(policy =>
	{
		policy.AllowAnyOrigin()
			  .AllowAnyMethod()
			  .AllowAnyHeader();
	});
});

builder.Services.AddDbContext<ChewioDbContext>(options =>
	options.UseSqlite("Data source=chewiodb.db"));

var app = builder.Build();

using var scope = app.Services.CreateScope();

var db = scope.ServiceProvider.GetRequiredService<ChewioDbContext>();

// db.Database.EnsureDeleted();
db.Database.EnsureCreated();

// builder.Services.AddControllers();


app.UseCors();

// app.MapControllers();

app.Run();