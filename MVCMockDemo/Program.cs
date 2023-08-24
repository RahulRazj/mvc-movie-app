using Microsoft.EntityFrameworkCore;
using MVCMockDemo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMovieRepo, MovieDbRepo>();
builder.Services.AddScoped<ICategoryRepo, CategoryDbRepo>();
builder.Services.AddDbContext<MovieDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ShoppingCart>(sc => ShoppingCart.GetCart(sc));
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

// custom route


app.MapControllerRoute(
    name: "music",
    pattern: "music/{*Welcome}",
    defaults: new { controller = "Music", action = "Welcome" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "myRoute",
    pattern: "emovies/{controller=Movie}/mov/{action=index}");


app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");

app.Run();
