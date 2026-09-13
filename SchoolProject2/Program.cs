using Microsoft.EntityFrameworkCore;
using SchoolProject2.Dbcontext;
using SchoolProject2.repostory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add the DbContext to the service container
builder.Services.AddDbContext<LocalDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ITeacherrepostory, Teacherrepostory>();
builder.Services.AddScoped<IStudentrepostory, Studentrepostory>();
builder.Services.AddScoped<IRoomrepostory, Roomrepostory>();
builder.Services.AddScoped<ICourserepostory, Courserepostory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
