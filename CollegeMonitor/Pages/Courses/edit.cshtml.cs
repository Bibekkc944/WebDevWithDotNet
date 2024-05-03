using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class EditCourseModel: PageModel
{    
   [BindProperty]
    public Course Course { get; set; }

    public void OnGet(int id)
    {
      collegeDbContext db = new();
      Course = db.Courses.Find(id);
    }
    public IActionResult OnPost()
    {
        collegeDbContext db = new();
        db.Courses.Update(Course);        //ef core
        db.SaveChanges();
      return RedirectToPage("Courses");

       
    }
}