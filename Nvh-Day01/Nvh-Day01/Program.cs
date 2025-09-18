var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! - Nguyễn Văn Huỳnh!");

app.Run();
