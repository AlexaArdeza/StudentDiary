StudentDiary_Exercise
│
├── StudentDiary.Domain
│   └── Entities
│       └── Student.cs
│
├── StudentDiary.Infrastructure
│   └── Data
│       └── ApplicationDbContext.cs   ✅ (DbContext here)
│
├── StudentDiary.Services
│   ├── Interfaces
│   │   └── IStudentService.cs
│   └── Implementations
│       └── StudentService.cs
│
└── StudentDiary.Presentation (your ASP.NET Core MVC project)
    ├── Controllers
    │   └── StudentsController.cs
    ├── Views
    │   └── Students
    │       ├── Index.cshtml
    │       ├── Create.cshtml
    │       ├── Edit.cshtml
    │       └── Delete.cshtml
    └── Program.cs
