using cicdApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

int key = 3;
var encryptionService = new EncryptionService(key);

app.MapGet("/", () => "Tjena kompis! Generera ett password med /generate-password");

app.MapGet("/encrypt", (string input) => encryptionService.Encrypt(input));
app.MapGet("/decrypt", (string input) => encryptionService.Decrypt(input));

// Genererar och krypterar ett slumpmässigt lösenord men returnerar bara den krypterade texten
app.MapGet("/generate-password", () =>
{
    var password = encryptionService.GenerateRandomPassword();
    return encryptionService.Encrypt(password);
});

app.Run();
