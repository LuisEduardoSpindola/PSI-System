using Microsoft.EntityFrameworkCore;
using PSI.Application.Interface;
using PSI.Infraestructure.Areas.Identity.Data;
using PSI.Infraestructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("IdentityPSIContextConnection") ?? throw new InvalidOperationException("Connection string 'IdentityPSIContextConnection' not found.");

builder.Services.AddDbContext<IdentityPSIContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<PSIUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<IdentityPSIContext>();

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IRepositoryPost, RepositoryPost>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapRazorPages();

app.UseAuthorization();

app.MapControllers();

app.Run();
