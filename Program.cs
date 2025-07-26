using Grilla.Components;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();
builder.Services.AddScoped(sp =>
{
    var client = new HttpClient { BaseAddress = new Uri("https://mainserver.ziursoftware.com/Ziur.API/basedatos_01/ZiurServiceRest.svc/") };
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "ae8bad44-7348-11ee-b962-0242ac120002");
    return client;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

app.Run();
