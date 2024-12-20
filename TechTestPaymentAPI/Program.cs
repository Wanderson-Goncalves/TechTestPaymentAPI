using TechTestPaymentAPI.src.Interfaces;
using TechTestPaymentAPI.src.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// services.AddDbContext<PaymentApiContext>

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ISaleRepository, SaleRepository>();

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
