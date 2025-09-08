using JobBoard.Mappings;
using JobBoard.Models;
using JobBoard.Repositories.JobRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<JobBoardDbContext>(options => options.UseSqlite("Data Source=jobBoard.db"));

builder.Services.AddScoped<IJobRepository, JobRepository>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<IApplicantRepository, ApplicantRepository>();
builder.Services.AddScoped<IWorkExperienceRepository, WorkExperienceRepository>();
builder.Services.AddScoped<IEducationRepository, EducationRepository>();
builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();

builder.Services.AddScoped<JobService>();
builder.Services.AddScoped<CompanyService>();
builder.Services.AddScoped<ApplicantService>();
builder.Services.AddScoped<WorkExperienceService>();
builder.Services.AddScoped<EducationService>();
builder.Services.AddScoped<ApplicationService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();



if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
