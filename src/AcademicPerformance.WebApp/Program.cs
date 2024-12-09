using AcademicPerformance.Contracts;
using AcademicPerformance.DAL;
using AcademicPerformance.Services;
using AcademicPerformance.Services.Helpers;
using AcademicPerformance.WebApp.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddServerSideBlazor(opt => { });
builder.Services.AddMudServices();

var connString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContextPool<AppDbContext>(opt => opt.UseSqlite(connString));

builder.Services.AddScoped<ISubjectService, SubjectService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddAutoMapper(opt => opt.AddProfile<MappingProfile>());


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler("/Error", createScopeForErrors: true);
app.UseHsts();
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
