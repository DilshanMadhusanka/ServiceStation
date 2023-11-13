var builder = WebApplication.CreateBuilder(args);    // default builder. web application ekak hadal denn mekat daganna 


builder.Services.AddControllersWithViews(); // MVC application ekaka base eka " AddControllersWithViews"

var app = builder.Build();  // build the application 

/* ude  line thunen wenne builder ekak hadanna. ekat ControllersWithViews tika add krann. ita passe build kranna.*/

//-------------------------------------------------------------------------------------------------------


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

app.Run();
