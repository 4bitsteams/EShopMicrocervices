var builder = WebApplication.CreateBuilder(args);

//Add the Service to the Container
var app = builder.Build();

//Configure the HTTP Request Pipeline

app.Run();
