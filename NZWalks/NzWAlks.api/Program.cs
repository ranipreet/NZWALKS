using Microsoft.EntityFrameworkCore;
using NzWAlks.api.Data;
using NzWAlks.api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRegionRepository,SqlRegionRepository>();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddDbContext<NZWalksDBContext>( options=>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("nzWalksConnections"));
});

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
