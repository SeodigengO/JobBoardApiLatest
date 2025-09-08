
using Microsoft.EntityFrameworkCore;

namespace JobBoard.Models;

public class JobBoardDbContext: DbContext
{
  public JobBoardDbContext(DbContextOptions<JobBoardDbContext> options) : base(options)
  {
  }

  // DbSets
  public DbSet<Company> Companies { get; set; }
  public DbSet<Job> Jobs { get; set; }
  public DbSet<Applicant> Applicants { get; set; }
  public DbSet<Application> Applications { get; set; }
  public DbSet<Education> EducationRecords { get; set; }
  public DbSet<WorkExperience> WorkExperiences { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
   
    modelBuilder.Entity<Company>()
        .HasMany(c => c.Jobs)
        .WithOne(j => j.Company)
        .HasForeignKey(j => j.CompanyId)
        .OnDelete(DeleteBehavior.Cascade);

   
    modelBuilder.Entity<Application>()
        .HasKey(a => a.ApplicationId);

    modelBuilder.Entity<Application>()
        .HasOne(a => a.Job)
        .WithMany(j => j.Applications)
        .HasForeignKey(a => a.JobId)
        .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<Application>()
        .HasOne(a => a.Applicant)
        .WithMany(ap => ap.Applications)
        .HasForeignKey(a => a.ApplicantId)
        .OnDelete(DeleteBehavior.Cascade);


    modelBuilder.Entity<Education>()
        .HasKey(e => e.EducationId);

    modelBuilder.Entity<Education>()
        .HasOne(e => e.Applicant)
        .WithMany(a => a.EducationHistory)
        .HasForeignKey(e => e.ApplicantId)
        .OnDelete(DeleteBehavior.Cascade);

  
    modelBuilder.Entity<WorkExperience>()
        .HasKey(w => w.WorkExperienceId);

    modelBuilder.Entity<WorkExperience>()
        .HasOne(w => w.Applicant)
        .WithMany(a => a.WorkExperiences)
        .HasForeignKey(w => w.ApplicantId)
        .OnDelete(DeleteBehavior.Cascade);

    base.OnModelCreating(modelBuilder);
  }
}