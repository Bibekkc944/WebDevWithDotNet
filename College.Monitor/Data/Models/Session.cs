using System.Formats.Asn1;
using System.Runtime.Intrinsics.X86;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;

public class Session
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string? Details { get; set; }   //string? = nullable
    public DateTime Start { get; set; }
    public float DurationInHours { get; set; }



    public int? CourseId { get; set; }   //foreign key always made in mini side or secondary table
                                         // int? can be nullable to create foreign key should be classname+primary key of primary table
    public Course? Course { get; set; }    // it should be null
}

//Course has multiple Sessions





// Dependency injection
// class A
// {

// }

// class B
// {
//     //A a1 = new();   //Tight coupling, hard coupling
//     // Depedency injection
//     // Most common : Constuctor injection

//     A a1;
//     public B(A a2)
//     {
//         a1 = a2;
//     }
// }

// class C
// {
//     B b;
// }