using Microsoft.EntityFrameworkCore;
using DatabaseFirst.Providers;

var builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("DBFDatabase");
if (connectionString is null) throw new MissingFieldException(nameof(connectionString));
builder.Services.AddDbContext<DBFContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();