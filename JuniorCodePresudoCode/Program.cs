// See https://aka.ms/new-console-template for more information
using Dapper;
using JuniorCodePresudoCode;
using JuniorCodePresudoCode.Patterns.Builder;
using JuniorCodePresudoCode.Patterns.ChainOfResponsibility;


//Chain of responsibility
RateLimiterMiddleware rateLimiterMiddleware = new RateLimiterMiddleware();
AuthMiddleware authMiddleware = new AuthMiddleware();
ValidationMiddleware validationMiddleware = new ValidationMiddleware();
RoutingMiddleware routingMiddleware = new RoutingMiddleware();

rateLimiterMiddleware.Next(authMiddleware).Next(validationMiddleware).Next(routingMiddleware);

Request request = new();

ApiResponse response = await rateLimiterMiddleware.Procces(request);

Console.WriteLine("Code is " + response.Code);
Console.WriteLine("Message is " + response.Message);



//Builder 

var queryBuilder = new PostgreSQLBuilder();
queryBuilder.Select("name, surname , phone_number, status, age");
queryBuilder.From("user");
queryBuilder.Where("age > @Age");
queryBuilder.Where("name LIKE @Name");

var query = queryBuilder.GetQuery();

query.Parameters.Add("@Age", 24);
query.Parameters.Add("@Name", "%Cухроб%");


Console.ReadLine();