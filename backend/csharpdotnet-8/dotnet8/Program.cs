using dotnet8.Interfaces;
using dotnet8.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                    options.JsonSerializerOptions.MaxDepth = 64;
                    options.JsonSerializerOptions.IncludeFields = true;
                });

// Add Swagger/OpenAPI support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services
builder.Services.AddSingleton<ICartService, CartService>();

// Configure the HTTP request pipeline
builder.WebHost.UseUrls("http://localhost:5050");

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run(); 