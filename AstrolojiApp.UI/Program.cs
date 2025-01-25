

using AstrolojiApp.Business.Abstract;
using AstrolojiApp.Business.Concrete;
using AstrolojiApp.Data.Abstract;
using AstrolojiApp.Data.Concrete.Context;
using AstrolojiApp.Data.Concrete.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IAppSettingRepository, AppSettingRepository>();
builder.Services.AddScoped<IAstrologCommentRepository, AstrologCommentRepository>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IDailyNewRepository, DailyNewRepository>();
builder.Services.AddScoped<IHoroscopeCommentRepository, HoroscopeCommentRepository>();
builder.Services.AddScoped<IHoroscopeGroupRepository, HoroscopeGroupRepository>();
builder.Services.AddScoped<IHoroscopeRepository, HoroscopeRepository>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();

builder.Services.AddScoped<IAppSettingService, AppSettingService>();
builder.Services.AddScoped<IAstrologCommentService, AstrologCommentService>();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IDailyNewService, DailyNewService>();
builder.Services.AddScoped<IHoroscopeCommentService, HoroscopeCommentService>();
builder.Services.AddScoped<IHoroscopeGroupService, HoroscopeGroupService>();
builder.Services.AddScoped<IServiceService, ServiceService>();
builder.Services.AddScoped<ISocialMediaService, SocialMediaService>();




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


app.MapAreaControllerRoute(
  name: "areas",
  pattern: "Admin/{controller=Home}/{action=Index}/{id?}",
  areaName: "Admin"
);



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
