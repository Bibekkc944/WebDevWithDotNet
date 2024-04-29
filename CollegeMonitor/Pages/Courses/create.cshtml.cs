using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CreateCourseModel: PageModel
{    
   [BindProperty]
    public Course Course { get; set; }
    public IActionResult OnPost()
    {
        collegeDbContext db = new();
        db.Courses.Add(Course);        //ef core
        db.SaveChanges();
      return RedirectToPage("Courses");

       
    }
}