var builder = WebApplication.CreateBuilder(args);    // default builder. web application ekak hadal denn mekat daganna 

builder.Services.AddControllersWithViews(); // MVC application ekaka base eka " AddControllersWithViews"

var app = builder.Build();  // build the application 

/* ude  line thunen wenne builder ekak hadanna. ekat ControllersWithViews tika add krann. ita passe build kranna.*/




//-------------------------------------------------------------------------------------------------------







// me kalla development environment eka

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}







//-----------------------------------------------------------------------------------------------------------


/* "use" kiyal thiyan ewa middlwear. hama request, respons ekema middlewear ekak run wenwa. user ha controller athara thiyenne */

app.UseHttpsRedirection(); // mona url eka gahuwath https walat convert kranna 
app.UseStaticFiles();  // www root folder eke thiayan css , js, lib, imges wage dewal use krannna

app.UseRouting();  // path eka 

app.UseAuthorization();  // katada access thiyenn and e monda 

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");




//-----------------------------------------------------------------------------------------------------------

app.Run();  // app eka run kranna 
