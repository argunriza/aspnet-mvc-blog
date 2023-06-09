using Microsoft.AspNetCore.Routing.Patterns;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Category",
    pattern: "category/{category}-{slug}",
    defaults: new { controller = "Category", action = "Index" }
);
app.MapControllerRoute(
    name: "Blog",
    pattern: "/blog/title-slug",
    defaults: new { controller = "Blog", action = "Detail" }
);
app.MapControllerRoute(
    name: "Page",
    pattern: "/blog/title-slug",
    defaults: new { controller = "Page", action = "Detail" }
);

app.Run();
