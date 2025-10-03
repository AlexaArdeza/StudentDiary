using System;

namespace StudentDiary.Infrastructure.Models
{
    public class DiaryEntry
    {
        public int Id { get; set; }
        public int UserId { get; set; }  // FK to User
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
