var builder = WebApplication.CreateBuilder(args);
var encryptText = builder.Configuration.GetValue<string>("Encrypt");
using var ms = new MemoryStream(Convert.FromBase64String(encryptText));

builder.Configuration.AddJsonStream(ms);

var app = builder.Build();

app.MapGet("/", () => builder.Configuration.GetValue<string>("Test"));

app.Run();
