
var builder = WebApplication.CreateBuilder(args);

// add dbContext and connectionString
var ConnectionString = builder.Configuration.GetConnectionString("sqlConnection") ??
                                    throw new InvalidOperationException("There is no Db With that server");

builder.Services.AddDbContext<ApplicationDBContext>(options =>
options.UseSqlServer(ConnectionString));

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

app.Run();
