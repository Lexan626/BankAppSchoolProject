using Microsoft.EntityFrameworkCore;
using BankAppInl�mming.Models;
using BankAppInl�mming.Repositories.Interfaces;
using BankAppInl�mming.Repositories;
using BankAppInl�mming.Services.Interfaces;
using BankAppInl�mming.Services;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<BankAppContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddTransient<IAccountService, AccountService>();
builder.Services.AddTransient<IAdminService, AdminService>();
builder.Services.AddTransient<ITransactionService, TransactionService>();

builder.Services.AddTransient<IAccountRepo, AccountRepo>();
builder.Services.AddTransient<IAdminRepo, AdminRepo>();
builder.Services.AddTransient<ITransactionRepo, TransactionRepo>();



var app = builder.Build();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
