using Microsoft.AspNetCore.Mvc.RazorPages;

public class CoursesModel: PageModel
{    
    public List<Course> Courses { get; set; }
    public async void OnGet()
    {
        // collegeDbContext db = new();
        // Courses = db.Courses.ToList();
        HttpClient http = new HttpClient();
        Courses = await http.GetFromJsonAsync<List<Course>>("http://localhost:5163/courses");
    }
}