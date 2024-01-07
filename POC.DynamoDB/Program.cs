using POC.DynamoDB.Initializers;
using POC.DynamoDB.Routers;

var builder = WebApplication.CreateBuilder(args);

DefaultInitializer.Initialize(builder);
ServiceInitializer.Initialize(builder);
RepositoryInitializer.Initialize(builder);
DynamoDbInitializer.Initialize(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

Router.AddRoutes(app);

app.Run();

