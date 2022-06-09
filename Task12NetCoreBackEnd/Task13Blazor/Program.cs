

using Task13Blazor.Models;
using Task13Blazor.Services;
using Task13Blazor.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddHttpClient<IServices<FinanceTypeModel>, FinanceTypeService>(client => client.BaseAddress = new Uri("https://localhost:7005/"));
builder.Services.AddHttpClient<IServices<MoneyOperationModel>, MoneyOperationService>(client => client.BaseAddress = new Uri("https://localhost:7005/"));
builder.Services.AddHttpClient<IReport, ReportService>(client => client.BaseAddress = new Uri("https://localhost:7005/"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
