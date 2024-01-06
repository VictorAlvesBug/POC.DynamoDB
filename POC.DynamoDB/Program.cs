using POC.DynamoDB.Initializers;
using POC.DynamoDB.Application.Dtos;
using POC.DynamoDB.Application.Interfaces;
using POC.DynamoDB.Application.Services;
using POC.DynamoDB.Domain.Models.Entities;
using POC.DynamoDB.Infrastructure.Interfaces;
using POC.DynamoDB.Infrastructure.Repositories;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

ServiceInitializer.Initialize(builder);
RepositoryInitializer.Initialize(builder);

var awsOptions = builder.Configuration.GetAWSOptions();
builder.Services.AddDefaultAWSOptions(awsOptions);
builder.Services.AddAWSService<IAmazonDynamoDB>();
builder.Services.AddScoped<IDynamoDBContext, DynamoDBContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/products/{pk}/{sk}", async (string pk, string sk, IProductService service) =>
{
	return await service.GetByPkAndSkAsync(pk, sk);
});

app.Run();

