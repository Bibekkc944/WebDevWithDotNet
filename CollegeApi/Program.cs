var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<collegeDbContext>();

var app = builder.Build();

// Minimal APIs
app.MapGet("/", () => "Learning developing REST API on .NET");
app.MapGet("/courses", (collegeDbContext db) => db.Courses.ToList());
app.MapGet("/courses/{id:int}", (int id, collegeDbContext db) => db.Courses.Find(id));
app.MapGet("/sessions", (collegeDbContext db) => db.Sessions.ToList());
app.MapGet("/sessions/{id:int}", (int id, collegeDbContext db) => db.Sessions.Find(id));

app.MapGet("/courses", (Course course, collegeDbContext db) => {
    db.Courses.Add(course);
    db.SaveChanges();
});


app.Run();
