using Microsoft.EntityFrameworkCore;
using StudentDiary.Infrastructure.Models;

namespace StudentDiary.Infrastructure.Data
{
    public class StudentDiaryContext : DbContext
    {
        public StudentDiaryContext(DbContextOptions<StudentDiaryContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relationship: User has many DiaryEntries
            modelBuilder.Entity<DiaryEntry>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
