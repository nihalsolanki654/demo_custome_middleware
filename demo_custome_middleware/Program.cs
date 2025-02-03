var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello World!");
}); 

app.Run();
