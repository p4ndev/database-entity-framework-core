using Microsoft.EntityFrameworkCore;
using CodeFirst.Providers;

var builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("CDFDatabase");
if (connectionString is null) throw new MissingFieldException(nameof(connectionString));
builder.Services.AddDbContext<CDFContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();