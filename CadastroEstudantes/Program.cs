using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CadastroEstudantes.Data;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);


// configura o "contexto" para se conectar ao banco de dados usando a ConnectionString
builder.Services.AddDbContext<CadastroEstudantesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CadastroEstudantesContext")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Estudantes}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
