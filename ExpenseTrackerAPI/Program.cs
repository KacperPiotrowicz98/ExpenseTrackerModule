using ExpenseTrackerAPI.EF;
using ExpenseTrackerAPI.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureAppConfiguration((context, builder) => {
    builder.SetDefaultConfig();

});
// Add services to the container.
builder.Services.AddTransientServices();
builder.Services.AddTransientMenager();
builder.Services.AddTransientRepositorys();
builder.Services.AddControllers();
//DbContext --------------------------------------------------------------------
builder.Services.AddDbContext<ExpenseContext>(options =>

   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")),
     ServiceLifetime.Transient); 

builder.Services.AddDbContextFactory<ExpenseContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")),
     ServiceLifetime.Transient);
//-----------------------------------------------------------------------------

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
