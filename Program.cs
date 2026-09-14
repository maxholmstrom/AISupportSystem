using Azure;
using Azure.AI.TextAnalytics;
using DotNetEnv;

Env.Load();
string endpoint = Environment.GetEnvironmentVariable("ENDPOINT") ?? throw new Exception("fel endpoint");
string key = Environment.GetEnvironmentVariable("KEY") ?? throw new Exception("fel key");

var client = new TextAnalyticsClient(
    new Uri(endpoint),
    new AzureKeyCredential(key)
);

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();
