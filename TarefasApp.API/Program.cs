using TarefasApp.Domain.Interfaces.Repositories;
using TarefasApp.Domain.Services;
using TarefasApp.Infra.Data.Contexts;
using TarefasApp.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

//Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("DefaultPolicy", policy =>
    {
        policy.WithOrigins("https://localhost:7121")
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials();
    });
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<ITarefaRepository, TarefaRepository>();
builder.Services.AddScoped<TarefaService>();

builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("DefaultPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
