using Tarazism.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TarazismDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TarazismDb")));

// Session (for login)
builder.Services.AddSession();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapDefaultControllerRoute();
app.Run();
