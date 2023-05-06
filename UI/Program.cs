using Business.DIContainer;
using Business.Quartz;
using DataAccess.Concrete;
using Entity.Concrete;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Quartz.Impl;
using Quartz;
using UI;
using UI.CustomCollectionExtensions;
using Microsoft.AspNetCore.WebSockets;
using Microsoft.Extensions.Hosting;
using Business.Options;
using Business.Concrete;
using Business.Interface;
using Hangfire;
using System.Configuration;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.AddContainer();
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>()
               .AddEntityFrameworkStores<Context>();
builder.Services.AddValidator();//CustomCollectionExtensions
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


#region Quartz
builder.Services.AddQuartz(q =>
{
    q.UseMicrosoftDependencyInjectionScopedJobFactory();
});
builder.Services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
builder.Services.AddScoped<HatKullanimEkle>();
builder.Services.AddSingleton<JobSchedule>(sp =>
{
    return new JobSchedule(typeof(HatKullanimEkle));

});

builder.Services.AddHostedService<QuartzHostedService>();
#endregion


builder.Services.AddHangfire(config =>
{
    config.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
    .UseSimpleAssemblyNameTypeSerializer()
    .UseRecommendedSerializerSettings()
    .UseSqlServerStorage("server=.;initial catalog=HatSatisSurec;integrated security=true");
})
.AddHangfireServer();


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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=GirisYap}/{id?}");

app.Run();
