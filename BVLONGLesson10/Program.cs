using Microsoft.EntityFrameworkCore;
using BVLONGLesson10.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// 1. Lấy chuỗi kết nối từ appsettings.json
var tvcConnection = builder.Configuration.GetConnectionString("TVCConnect");

// 2. Đăng ký DbContext (Đã sửa đúng chữ 'l' thường ở BVLONGlesson10Context)
builder.Services.AddDbContext<BVLONGlesson10Context>(options =>
    options.UseSqlServer(tvcConnection));

var app = builder.Build();

// Configure the HTTP request pipeline.
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
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();