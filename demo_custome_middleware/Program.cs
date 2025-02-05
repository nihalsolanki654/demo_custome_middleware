var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("welcome to istar\n");
    await next();
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("welcome to cvm\n");
    await next();
});

// app.run() will never call subsequent middleware

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello World!");
});


// we can not create multiple middleware in the same file usign app.run method
// to create multiple middleware we cane use app.use method
// use middleware allow you to create multiple middleware in the same file


app.Run();
