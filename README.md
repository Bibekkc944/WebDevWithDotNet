# Web Development With .Net

 ww -Earlu 1990's 
 ASP - MS, JSP - SUN
 .NET Framework - Early 2000's - Windows only, last version 4.8
 ASP.NET (Web Forms)
 MVC - Model View Controller - 2007
 ASP.NET MVC - 2008


 2015/16 - .NET core (cross platform, opensource)
 ASP.NET Core

 ## SDLC
 ### Environments (Physical Server and APP urls)
 CollegeMonitor - https://CollegeMOnitor.com

 1. Developer - Local : Day Environment
 1. QA - Code Changes Deployed, Tst Environment (https://tst.CollegeMOnitor.com)
 1. INT - All code changes Integration Environment (https://int.CollegeMOnitor.com)
 1. UAT - PO/TPO/BA, User Acceptance Testing (https://uat.CollegeMOnitor.com)
 1. PROD - Production Environment (https://CollegeMOnitor.com)

 # CollegeMonitor Requirements
 
 ## Entities/Tables/Models
 1. Session - Id, Title, start, Duration
 1. Course - Id, Name, TextBook, CreditHrs
 1. Student - Id, Name, Address, Email, Program, Semester

 Course has multiple classes (one to many)
 Student may enroll on mujltiple courses and a course can be studied by multiple students(many to many)


 ## Classwork
 1. On courses page, number should be 1,2,3,4...N
 1. For each Course, there should be edit and delete button
 1. When edit is clicked, course edit page should be displayed with course data prepopulated