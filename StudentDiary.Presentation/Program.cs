using Microsoft.EntityFrameworkCore;
using StudentDiary.Infrastructure.Data;
using StudentDiary.Services.Interfaces;
using StudentDiary.Services.Implementations;

using StudentDiary.Infrastructure.Data;
using StudentDiary.Services.Implementations;
using StudentDiary.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

builder.Services.AddDbContext<StudentDiaryContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IStudentService, StudentService>();


var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register Services
builder.Services.AddScoped<IStudentService, StudentService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
