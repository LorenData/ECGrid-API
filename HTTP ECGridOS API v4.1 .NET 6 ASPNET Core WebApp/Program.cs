var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddHttpClient<IECGridOSClient, ECGridOSClient>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["ECGridOS:Host"]);
    client.DefaultRequestHeaders.ConnectionClose = false;
    client.Timeout = TimeSpan.FromMinutes(10);
})
.SetHandlerLifetime(TimeSpan.FromMinutes(720)); // Reuse connection pool for 12 hour before getting a new one


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
