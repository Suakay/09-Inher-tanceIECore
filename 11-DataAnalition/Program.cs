using _11_DataAnalition.Model;

Console.WriteLine("Hello World!");
using (AppContext context = new AppContext()) ;
{
    Contact contact = new Contact();
    contact.FullName = "Ali";
    contact.LastName = "VELİ";
    contact.Email = "ASDS";
    contact.LastAccessed= DateTime.Now; 

    context .Contac
        //context.Contact.Add(contact);
        //context.SaveChanges();
        ------------------------------------------------------------------------------

    /*Laptop:ID,NAME,STUDENT
     * sTUDENT:sTUDENTnO,NAME,AGE,SCHOOLNO
     * STUDENTdETAİL:ID,DETAİL,STUDENTNO
     * lESSON:lESSONnO,NAME,DEPARTMENID
     * DEPARTMENT:ID,NAME,
     * SCHOOL:ID,NAME,
    /*
Laptop : Id, Name, StudentNo, 
Student: StudentNo, Name, Age, SchoolNo
StudentDetail : Id, Detail, StudentNo
Lesson: LessonNo, Name, DepartmentId
Department: Id, Name 
School: Id, Name, Departments, Students

DataAnnotaion, FluentAPI

1 School N Students - 1 Student 1 School
1 Lesson N Students - 1 Students N Lessons
1 Student 1 Laptop
1 Student 1 StudentDetail

School --> "Okul"
School Name --> Okul Adı"

1 Department N Lessons
1 Department N Schools - 1 School N Departments

*/
}