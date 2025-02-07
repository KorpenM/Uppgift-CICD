using cicdApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

int key = 3;
var encryptionService = new EncryptionService(key);

app.MapGet("/", () => "Tjena kompis!");

app.MapGet("/encrypt", (string input) => encryptionService.Encrypt(input));
app.MapGet("/decrypt", (string input) => encryptionService.Decrypt(input));

// Genererar och krypterar ett slumpmässigt lösenord
app.MapGet("/generate-password", () =>
{
    var password = encryptionService.GenerateRandomPassword();
    var encryptedPassword = encryptionService.Encrypt(password);
    return new { Original = password, Encrypted = encryptedPassword };
});

app.Run();
