using Numerology.Api.Repositories;
using Numerology.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);

// Register services
builder.Services.AddTransient<ILettersNumberRepository, LettersNumberRepository>();
builder.Services.AddTransient<INumberReducerService, NumberReducerService>();

builder.Services.AddTransient<INameService, NameService>();
builder.Services.AddTransient<IDateOfBirthService, DateOfBirthService>();
builder.Services.AddTransient<IPersonService, PersonService>();

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
