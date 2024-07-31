using MudBlazor.Services;
using NBCEpagBret.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// MudBlazor
builder.Services.AddMudServices();

// DbContext
var dbConnectionString = builder.Configuration.GetSection("DbSettings")["ConnectionString"]
    ?? throw new NullReferenceException("Database connection string is not defined");
var dbName = builder.Configuration.GetSection("DbSettings")["DatabaseName"]
    ?? throw new NullReferenceException("Database name is not defined");
builder.Services.AddEpagBretDbContext(dbConnectionString, dbName);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
