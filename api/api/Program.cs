using core.IRepository;
using core.IService;
using infrastructure.Repository;
using infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add repository to the container.
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IDemoRepository, DemoRepository>();


// Add services to the container.
builder.Services.AddScoped<IDemoService, DemoService>();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null; // Disable camelCase
});

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
